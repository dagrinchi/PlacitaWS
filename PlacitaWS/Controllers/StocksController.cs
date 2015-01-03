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
using System.Diagnostics;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace PlacitaWS.Controllers
{
    [Authorize]
    public class StocksController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UserManager<ApplicationUser> _userManager;

        public StocksController()
        {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        // GET: api/Stocks
        [AllowAnonymous]
        public IQueryable<Stock> GetStocks()
        {
            return db.Stocks
                .Include("Product")
                .Include("Unit")
                .Include("GeoPoint")
                .Include("User")
                .Include("User.User")
                .Where(s => s.ExpiresAt >= DateTime.Now);
        }

        // GET: api/MyStocks
        [Route("api/MyStocks/{hasExpired}")]
        public IQueryable<Stock> GetMyStocks(int hasExpired)
        {
            ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            if (hasExpired == 0)
            {
                return db.Stocks
                    .Include("Product")
                    .Include("Unit")
                    .Include("GeoPoint")
                    .Include("User")
                    .Include("User.User")
                    .Where(s => s.User.Id == appuser.Id)
                    .Where(s => s.ExpiresAt >= DateTime.Now);
            }
            else
            {
                return db.Stocks
                    .Include("Product")
                    .Include("Unit")
                    .Include("GeoPoint")
                    .Include("User")
                    .Include("User.User")
                    .Where(s => s.User.Id == appuser.Id)
                    .Where(s => s.ExpiresAt <= DateTime.Now);
            }
        }


        // GET: api/Stocks/5
        [AllowAnonymous]
        [ResponseType(typeof(Stock))]
        public async Task<IHttpActionResult> GetStock(int id)
        {
            Stock stock = await db.Stocks.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);
        }

        // POST: api/USSDStocks
        [Route("api/USSDStocks")]
        public IHttpActionResult PostUSSDStock(USSDStockBinding stockModel)
        {
           ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            Product product = (from pr in db.Products
                                     where pr.Code == stockModel.ProductCode
                                     select pr).FirstOrDefault();
            Unit unit = (from u in db.Units
                                where u.Code == stockModel.UnitCode
                         select u).FirstOrDefault();  
            Place place = (from pl in db.Places
                                 where pl.Code == stockModel.LocationCode
                           select pl).FirstOrDefault();

            if (product == null || unit == null || place == null) {
                return NotFound();
            }
            
            Stock stock = new Stock()
            {
                Product = product,
                Unit = unit,
                PricePerUnit = stockModel.PricePerUnit,
                ExpiresAt = DateTime.Now.AddDays(stockModel.ExpiresDays),
                Qty = stockModel.Qty,
                GeoPoint = new GeoPoint()
                {
                    Latitude = place.Latitude,
                    Longitude = place.Longitude,
                    Address = place.Name,
                    Town = "",
                    State = "",
                    Country = ""
                },
                User = appuser
            };

            db.Stocks.Add(stock);
            db.SaveChanges();

            return Ok(stock);
        }

        // POST: api/Stocks
        [ResponseType(typeof(Stock))]
        public async Task<IHttpActionResult> PostStock(StockBinding stockModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser appuser = await _userManager.FindByIdAsync(User.Identity.GetUserId());
            var stock = new Stock()
            {
                Product = await db.Products.FindAsync(stockModel.ProductId),
                Unit = await db.Units.FindAsync(stockModel.UnitId),
                PricePerUnit = stockModel.PricePerUnit,
                ExpiresAt = stockModel.ExpiresAt,
                Qty = stockModel.Qty,
                GeoPoint = new GeoPoint()
                {
                    Latitude = stockModel.GeoPoint.Latitude,
                    Longitude = stockModel.GeoPoint.Longitude,
                    Address = stockModel.GeoPoint.Address,
                    Town = stockModel.GeoPoint.Town,
                    State = stockModel.GeoPoint.State,
                    Country = stockModel.GeoPoint.Country
                },
                User = appuser
            };

            db.Stocks.Add(stock);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = stock.Id }, stock);
        }

        // DELETE: api/Stocks/5
        [ResponseType(typeof(Stock))]
        public async Task<IHttpActionResult> DeleteStock(int id)
        {
            Stock stock = await db.Stocks.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }

            db.Stocks.Remove(stock);
            await db.SaveChangesAsync();

            return Ok(stock);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StockExists(int id)
        {
            return db.Stocks.Count(e => e.Id == id) > 0;
        }
    }
}