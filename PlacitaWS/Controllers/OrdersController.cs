using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.IO;
using PlacitaWS.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace PlacitaWS.Controllers
{
    [Authorize]
    public class OrdersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UserManager<ApplicationUser> _userManager;

        public OrdersController()
        {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }
        
        [Route("api/MyPurchases")]
        public IQueryable<Order> GetMyPurchases()
        {
            ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            return ((from o in db.Orders
                     where o.User.Id == appuser.Id
                     select o) as IQueryable<Order>)
                        .Include("Stock")
                        .Include("Stock.Product")
                        .Include("Stock.Unit")
                        .Include("Stock.GeoPoint")
                        .Include("Stock.User.User")
                        .Include("GeoPoint")
                        .Include("User.User");
        }

        [Route("api/MyOrders")]
        public IQueryable<Order> GetMyOrders()
        {
            ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            return ((from o in db.Orders
                   join s in db.Stocks on o.Stock.Id equals s.Id
                   where s.User.Id == appuser.Id
                   select o) as IQueryable<Order>)
                        .Include("Stock")
                        .Include("Stock.Product")
                        .Include("Stock.Unit")
                        .Include("Stock.GeoPoint")
                        .Include("Stock.User.User")
                        .Include("GeoPoint")
                        .Include("User.User");
        }

        // GET: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> GetOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.Id)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(OrderBinding orderModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            Stock stock = db.Stocks              
                .Include("Product")
                .Include("Unit")
                .Include("User")
                .Include("User.User")
                .Where(st => st.Id == orderModel.StockId).FirstOrDefault();

            var order = new Order()
            {
                Stock = stock,
                FullName = orderModel.FullName,
                Phone = orderModel.Phone,
                Qty = orderModel.Qty,
                GeoPoint = new GeoPoint()
                {
                    Latitude = orderModel.GeoPoint.Latitude,
                    Longitude = orderModel.GeoPoint.Longitude,
                    Address = orderModel.GeoPoint.Address,
                    Town = orderModel.GeoPoint.Town,
                    State = orderModel.GeoPoint.State,
                    Country = orderModel.GeoPoint.Country
                },
                User = appuser
            };
            db.Orders.Add(order);
            db.SaveChanges();

            string sms1 = "http://200.31.80.34/Bolsa_Mensajes/AgroNet/CGI/ReceiverSMSFormulario.php";
            sms1 += "?to=85050";
            sms1 += String.Format("&operador={0}", GetOperator(stock.User.User.Phone));                        
            sms1 += String.Format("&mensaje=Buenas_Tienes_un_nuevo_pedido_Ref_{0}_de_{1}_{2}_de_{3}_por_{4}_{5}",
                order.Id,
                order.Qty, 
                stock.Unit.Code,
                System.Text.RegularExpressions.Regex.Replace(stock.Product.Name.Trim(), @"\s+", "_"),
                System.Text.RegularExpressions.Regex.Replace(order.FullName.Trim(), @"\s+", "_"),
                order.Phone);
            sms1 += String.Format("&movil={0}", stock.User.User.Phone);
            sms1 += "&idmessage=11111111";
            sms1 += "&concat=0";
            SendSMS(sms1);

            string sms2 = "http://200.31.80.34/Bolsa_Mensajes/AgroNet/CGI/ReceiverSMSFormulario.php";
            sms2 += "?to=85050";
            sms2 += String.Format("&operador=", order.Phone);
            sms2 += String.Format("&mensaje=Buenas_Tu_pedido_de_{0}_{1}_de_{2}_Ref_{3}_fue_creado_exitosamente_Puede_comunicarse_con_{4}_{5}",
                order.Qty,
                stock.Unit.Code,
                System.Text.RegularExpressions.Regex.Replace(stock.Product.Name.Trim(), @"\s+", "_"), 
                order.Id,
                System.Text.RegularExpressions.Regex.Replace(stock.User.User.Name.Trim(), @"\s+", "_"), 
                stock.User.User.Phone);
            sms2 += String.Format("&movil={0}", order.Phone);
            sms2 += "&idmessage=11111111";
            sms2 += "&concat=0";
            SendSMS(sms2);

            return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        }

        void SendSMS(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            
            Console.WriteLine (((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream ();
            StreamReader reader = new StreamReader (dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine (responseFromServer);
            
            reader.Close();
            response.Close();
        }

        string GetOperator(string phone)
        {
            string operador = "1";
            switch (phone.Substring(0, 3))
            {
                case "300":
                    operador += "3";
                    break;
                case "301":
                    operador += "3";
                    break;
                case "310":
                    operador += "1";
                    break;
                case "311":
                    operador += "1";
                    break;
                case "312":
                    operador += "1";
                    break;
                case "313":
                    operador += "1";
                    break;
                case "314":
                    operador += "1";
                    break;
                case "315":
                    operador += "2";
                    break;
                case "316":
                    operador += "2";
                    break;
                case "317":
                    operador += "2";
                    break;
                case "318":
                    operador += "3";
                    break;
                case "320":
                    operador += "1";
                    break;
                case "321":
                    operador += "1";
                    break;
                default:
                    operador += "1";
                    break;
            }

            return operador;
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> DeleteOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.Id == id) > 0;
        }
    }
}