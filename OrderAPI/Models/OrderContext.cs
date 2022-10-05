/*using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OrderAPI.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("Server=localhost;Database=tms;Trusted_Connection=True;")
        {
//            Database.SetInitializer(new OrderInitializer());
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
*/