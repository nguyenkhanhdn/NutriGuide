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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Users
            modelBuilder.Entity<NCUser>().HasData(
            new NCUser { Id = 1, FullName = "Nguyễn Văn A", Email = "nguyenvana@example.com", DateOfBirth = new DateTime(1990, 5, 20), Gender = "Male" },
            new NCUser { Id = 2, FullName = "Trần Thị B", Email = "tranthib@example.com", DateOfBirth = new DateTime(1985, 10, 15), Gender = "Female" },
            new NCUser { Id = 3, FullName = "Lê Văn C", Email = "levanc@example.com", DateOfBirth = new DateTime(2000, 8, 10), Gender = "Male" },
            new NCUser { Id = 4, FullName = "Phạm Thị D", Email = "phamthid@example.com", DateOfBirth = new DateTime(1995, 12, 25), Gender = "Female" },
            new NCUser { Id = 5, FullName = "Hoàng Văn E", Email = "hoangvane@example.com", DateOfBirth = new DateTime(1992, 7, 30), Gender = "Male" },
            new NCUser { Id = 6, FullName = "Đặng Thị F", Email = "dangthif@example.com", DateOfBirth = new DateTime(1988, 3, 18), Gender = "Female" },
            new NCUser { Id = 7, FullName = "Bùi Văn G", Email = "buivang@example.com", DateOfBirth = new DateTime(2002, 6, 5), Gender = "Male" },
            new NCUser { Id = 8, FullName = "Ngô Thị H", Email = "ngothih@example.com", DateOfBirth = new DateTime(1997, 9, 22), Gender = "Female" },
            new NCUser { Id = 9, FullName = "Dương Văn I", Email = "duongvani@example.com", DateOfBirth = new DateTime(1991, 11, 11), Gender = "Male" },
            new NCUser { Id = 10, FullName = "Tô Thị J", Email = "tothij@example.com", DateOfBirth = new DateTime(1999, 4, 8), Gender = "Female" },
            new NCUser { Id = 11, FullName = "Lương Văn K", Email = "luongvank@example.com", DateOfBirth = new DateTime(1986, 1, 17), Gender = "Male" },
            new NCUser { Id = 12, FullName = "Mai Thị L", Email = "maithil@example.com", DateOfBirth = new DateTime(1994, 2, 28), Gender = "Female" },
            new NCUser { Id = 13, FullName = "Vũ Văn M", Email = "vuvan@example.com", DateOfBirth = new DateTime(2001, 7, 14), Gender = "Male" },
            new NCUser { Id = 14, FullName = "Lý Thị N", Email = "lythin@example.com", DateOfBirth = new DateTime(1987, 5, 6), Gender = "Female" },
            new NCUser { Id = 15, FullName = "Trịnh Văn O", Email = "trinhvano@example.com", DateOfBirth = new DateTime(1993, 12, 3), Gender = "Male" }
        );


            // Seed HealthRecords
            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<HealthRecord>().HasData(
                    new HealthRecord
                    {
                        Id = i,
                        UserId = i,
                        DateRecorded = DateTime.UtcNow.AddDays(-i),
                        BloodSugar = 90 + i,
                        SystolicPressure = 120 + (i % 10),
                        DiastolicPressure = 80 + (i % 5)
                    }
                );
            }

            // Seed FoodRecords
            string[] foods = { "Cơm trắng", "Bánh mì", "Táo", "Chuối", "Rau xanh", "Thịt bò", "Cá hồi", "Sữa chua", "Trứng", "Dưa hấu" };
            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<FoodRecord>().HasData(
                    new FoodRecord
                    {
                        Id = i,
                        UserId = (i % 10) + 1,
                        FoodName = foods[i % foods.Length],
                        GlycemicIndex = 50 + (i % 30),
                        DateConsumed = DateTime.UtcNow.AddDays(-i)
                    }
                );
            }
        }

        public DbSet<NCUser> Users { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<FoodRecord> FoodRecords { get; set; }
        
        
        //Các bảng dữ liệu cũ -> nay không dùng nữa
        public DbSet<Bmi> Bmis { get; set; }
        public DbSet<Nutri> Nutris { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
