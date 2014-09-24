using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PlacitaWS.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace PlacitaWS.Controllers
{
    [Authorize]
    public class MyStocksController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UserManager<ApplicationUser> _userManager;

        public MyStocksController() {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        // GET: api/MyStocks
        public IQueryable<Stock> GetStocks()
        {
            ApplicationUser appuser = _userManager.FindById(User.Identity.GetUserId());
            return db.Stocks
                .Include("Product")
                .Include("Unit")
                .Include("GeoPoint")
                .Include("User")
                .Include("User.User")
                .Where(s => s.User.Id == appuser.Id);
        }

    }
}