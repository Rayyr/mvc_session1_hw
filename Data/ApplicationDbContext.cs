using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using mvc_trial.Models;


namespace mvc_trial.Data
{
    public class ApplicationDbContext : DbContext
    {
        //database table call : categories 
        public DbSet <Category> categories { get; set; }
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseSqlServer("Server=.;Database=mvc_db;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=mvc_db;Trusted_Connection=True;");

        }

        //add data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "category 1" ,description="this is category 1"},
                new Category { id = 2, name = "category 2" , description = "this is category 2" },
                new Category { id = 3, name = "category 3" , description = "this is category 3" },
                new Category { id = 4, name = "category 4" , description = "this is category 4" },
                new Category { id = 5, name = "category 5" , description = "this is category 5" },
                new Category { id = 6, name = "category 6" , description = "this is category 6" }
            );
                

        }
    }
}
