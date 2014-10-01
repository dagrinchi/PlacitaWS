using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PlacitaWS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    
    [DataContract]
    public class ApplicationUser : IdentityUser
    {
        [DataMember]
        public override string Email { get; set; }
        
        [DataMember]
        public User User { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AzureConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Unit> Units { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Stock> Stocks { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Price> Prices { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.NewsFeed> NewsFeeds { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Place> Places { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.OrderStatus> OrderStatus { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.OrderDelivered> OrderDelivereds { get; set; }
    }
}