using BookManagement.DTO;
using System.Data.Entity.ModelConfiguration;

namespace BookManagement.Infrastructure.Configurations
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            this.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);

            // Configure a one-to-one relationship between Student & StudentAddress
            //this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
            //    .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}
