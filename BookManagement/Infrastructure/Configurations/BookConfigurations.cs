using BookManagement.DTO;
using System.Data.Entity.ModelConfiguration;

namespace BookManagement.Infrastructure.Configurations
{
    public class BookConfigurations : EntityTypeConfiguration<Book>
    {
        public BookConfigurations()
        {
            this.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.Author)
                .IsConcurrencyToken();

            // Configure a one-to-one relationship between Student & StudentAddress
            //this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
            //    .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}
