using Microsoft.EntityFrameworkCore;
using MyGarden.Models;

namespace MyGarden.Data
{
    public class MyGardenContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=garden.db"); // =]
        }
    }
}