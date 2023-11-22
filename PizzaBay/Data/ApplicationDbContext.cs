using Microsoft.EntityFrameworkCore;
using PizzaBay.Models;

namespace PizzaBay.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrderModels { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
