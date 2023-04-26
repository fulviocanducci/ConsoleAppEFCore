using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ConsoleAppEFCore.Models.Mappings
{
   public class PeopleMapping : IEntityTypeConfiguration<People>
   {
      public void Configure(EntityTypeBuilder<People> builder)
      {
         builder.ToTable("Peoples");
         builder.HasKey(c => c.Id);
         builder.Property(c => c.Id)
            .HasColumnName("Id")
            .UseIdentityColumn();

         builder.Property(c => c.Name)
            .HasColumnName("Name")
            .HasMaxLength(50)
            .IsRequired();
      }
   }
}
