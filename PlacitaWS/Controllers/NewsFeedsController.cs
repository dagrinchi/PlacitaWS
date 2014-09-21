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
    public class NewsFeedsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/NewsFeeds
        public IQueryable<NewsFeed> GetNewsFeeds()
        {
            return db.NewsFeeds;
        }

        // GET: api/NewsFeeds/5
        [ResponseType(typeof(NewsFeed))]
        public async Task<IHttpActionResult> GetNewsFeed(int id)
        {
            NewsFeed newsFeed = await db.NewsFeeds.FindAsync(id);
            if (newsFeed == null)
            {
                return NotFound();
            }

            return Ok(newsFeed);
        }

        // PUT: api/NewsFeeds/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNewsFeed(int id, NewsFeed newsFeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != newsFeed.Id)
            {
                return BadRequest();
            }

            db.Entry(newsFeed).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsFeedExists(id))
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

        // POST: api/NewsFeeds
        [ResponseType(typeof(NewsFeed))]
        public async Task<IHttpActionResult> PostNewsFeed(NewsFeed newsFeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NewsFeeds.Add(newsFeed);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = newsFeed.Id }, newsFeed);
        }

        // DELETE: api/NewsFeeds/5
        [ResponseType(typeof(NewsFeed))]
        public async Task<IHttpActionResult> DeleteNewsFeed(int id)
        {
            NewsFeed newsFeed = await db.NewsFeeds.FindAsync(id);
            if (newsFeed == null)
            {
                return NotFound();
            }

            db.NewsFeeds.Remove(newsFeed);
            await db.SaveChangesAsync();

            return Ok(newsFeed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NewsFeedExists(int id)
        {
            return db.NewsFeeds.Count(e => e.Id == id) > 0;
        }
    }
}