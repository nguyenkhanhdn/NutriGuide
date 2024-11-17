using Microsoft.EntityFrameworkCore;

namespace NutriGuide.Models
{
    public class NutriGuideDbContext:DbContext
    {
        public NutriGuideDbContext(DbContextOptions<NutriGuideDbContext> options): base(options) 
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NutriGuide;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Bmi> Bmis { get; set; }

        public DbSet<Nutri> Nutris { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
