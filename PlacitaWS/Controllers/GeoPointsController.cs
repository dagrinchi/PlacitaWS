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
    public class GeoPointsController : ApiController
    {
        private PlacitaWSContext db = new PlacitaWSContext();

        // GET: api/GeoPoints
        public IQueryable<GeoPoint> GetGeoPoints()
        {
            return db.GeoPoints;
        }

        // GET: api/GeoPoints/5
        [ResponseType(typeof(GeoPoint))]
        public async Task<IHttpActionResult> GetGeoPoint(int id)
        {
            GeoPoint geoPoint = await db.GeoPoints.FindAsync(id);
            if (geoPoint == null)
            {
                return NotFound();
            }

            return Ok(geoPoint);
        }

        // PUT: api/GeoPoints/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGeoPoint(int id, GeoPoint geoPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != geoPoint.Id)
            {
                return BadRequest();
            }

            db.Entry(geoPoint).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeoPointExists(id))
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

        // POST: api/GeoPoints
        [ResponseType(typeof(GeoPoint))]
        public async Task<IHttpActionResult> PostGeoPoint(GeoPoint geoPoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GeoPoints.Add(geoPoint);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = geoPoint.Id }, geoPoint);
        }

        // DELETE: api/GeoPoints/5
        [ResponseType(typeof(GeoPoint))]
        public async Task<IHttpActionResult> DeleteGeoPoint(int id)
        {
            GeoPoint geoPoint = await db.GeoPoints.FindAsync(id);
            if (geoPoint == null)
            {
                return NotFound();
            }

            db.GeoPoints.Remove(geoPoint);
            await db.SaveChangesAsync();

            return Ok(geoPoint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GeoPointExists(int id)
        {
            return db.GeoPoints.Count(e => e.Id == id) > 0;
        }
    }
}