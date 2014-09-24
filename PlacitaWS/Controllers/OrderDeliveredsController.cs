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
using PlacitaWS.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace PlacitaWS.Controllers
{
    [Authorize]
    public class OrderDeliveredsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UserManager<ApplicationUser> _userManager;

        public OrderDeliveredsController()
        {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        // GET: api/OrderDelivereds
        public IQueryable<OrderDelivered> GetOrderDelivereds()
        {
            return db.OrderDelivereds;
        }

        // GET: api/OrderDelivereds/5
        [ResponseType(typeof(OrderDelivered))]
        public async Task<IHttpActionResult> GetOrderDelivered(int id)
        {
            OrderDelivered orderDelivered = await db.OrderDelivereds.FindAsync(id);
            if (orderDelivered == null)
            {
                return NotFound();
            }

            return Ok(orderDelivered);
        }

        // PUT: api/OrderDelivereds/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrderDelivered(int id, OrderDelivered orderDelivered)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderDelivered.Id)
            {
                return BadRequest();
            }

            db.Entry(orderDelivered).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDeliveredExists(id))
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

        // POST: api/OrderDelivereds
        [ResponseType(typeof(OrderDelivered))]
        public async Task<IHttpActionResult> PostOrderDelivered(OrderDeliveredBinding orderDeliveredModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            ApplicationUser appuser = await _userManager.FindByIdAsync(User.Identity.GetUserId());
            var orderDelivered = new OrderDelivered()
            {
                OrderStatus = await db.OrderStatus.FindAsync(orderDeliveredModel.OrderStatusId),
                Order = await db.Orders.FindAsync(orderDeliveredModel.OrderId),
                Comment = orderDeliveredModel.Comment,
                User = appuser
            };

            db.OrderDelivereds.Add(orderDelivered);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = orderDelivered.Id }, orderDelivered);
        }

        // DELETE: api/OrderDelivereds/5
        [ResponseType(typeof(OrderDelivered))]
        public async Task<IHttpActionResult> DeleteOrderDelivered(int id)
        {
            OrderDelivered orderDelivered = await db.OrderDelivereds.FindAsync(id);
            if (orderDelivered == null)
            {
                return NotFound();
            }

            db.OrderDelivereds.Remove(orderDelivered);
            await db.SaveChangesAsync();

            return Ok(orderDelivered);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderDeliveredExists(int id)
        {
            return db.OrderDelivereds.Count(e => e.Id == id) > 0;
        }
    }
}