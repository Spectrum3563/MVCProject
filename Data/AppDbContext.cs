using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data {
    public class AppDbContext : IdentityDbContext<ApplicationUser> {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<FieldStudy> FieldStudies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can go here
        }
    }
}