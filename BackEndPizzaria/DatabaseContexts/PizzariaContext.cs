using BackEndPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndPizzaria.Context
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Pizzaria> pizzarias { get; set; }
    }
}
