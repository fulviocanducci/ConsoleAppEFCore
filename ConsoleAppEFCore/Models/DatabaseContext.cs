using ConsoleAppEFCore.Models.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleAppEFCore.Models
{
   public class DatabaseContext : DbContext
   {
      public DbSet<People> Peoples { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new PeopleMapping());
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=EFTest;User Id=sa;Password=senha;;TrustServerCertificate=True");
      }
   }
}
