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
    public class StocksController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UserManager<ApplicationUser> _userManager;

        public StocksController() {
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
                .Include("User.User");
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
                    Longitude = stockModel.GeoPoint.Longitude
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