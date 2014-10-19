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

namespace PlacitaWS.Controllers
{
    [Authorize]
    public class PricesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Prices
        [AllowAnonymous]
        public IQueryable<Price> GetPrices()
        {
            return db.Prices.Include("Product").Include("Unit");
        }

        // GET: api/Prices/5
        [AllowAnonymous]
        [ResponseType(typeof(Price))]
        public async Task<IHttpActionResult> GetPrice(int id)
        {
            //Price price = await db.Prices.FindAsync(id);
            Price price = await ((from p in db.Prices
                           where p.Id == id
                           select p) as IQueryable<Price>)
                           .Include("Unit")
                           .Include("Product")
                           .SingleAsync();
            if (price == null)
            {
                return NotFound();
            }

            return Ok(price);
        }

        // GET: api/PricesByProductCode/11
        [AllowAnonymous]
        [Route("api/PriceByProductCode/{productCode}")]
        public IQueryable<Price> GetPriceByProductCode(String productCode)
        {
            return ((from p in db.Prices
                   where p.Product.Code == productCode
                   orderby p.Created descending
                   select p) as IQueryable<Price>)
                   .Take(5)
                   .Include("Product")
                   .Include("Unit");
        }

        // PUT: api/Prices/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPrice(int id, Price price)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != price.Id)
            {
                return BadRequest();
            }

            db.Entry(price).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceExists(id))
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

        // POST: api/Prices
        [ResponseType(typeof(Price))]
        public async Task<IHttpActionResult> PostPrice(Price price)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Prices.Add(price);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = price.Id }, price);
        }

        // DELETE: api/Prices/5
        [ResponseType(typeof(Price))]
        public async Task<IHttpActionResult> DeletePrice(int id)
        {
            Price price = await db.Prices.FindAsync(id);
            if (price == null)
            {
                return NotFound();
            }

            db.Prices.Remove(price);
            await db.SaveChangesAsync();

            return Ok(price);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PriceExists(int id)
        {
            return db.Prices.Count(e => e.Id == id) > 0;
        }
    }
}