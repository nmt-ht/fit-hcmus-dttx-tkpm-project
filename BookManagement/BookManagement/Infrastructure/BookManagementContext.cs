using BookManagement.DTO;
using BookManagement.Infrastructure.Configurations;
using System.Data.Entity;

namespace BookManagement.Infrastructure
{
    public class BookManagementContext: DbContext
    {
        public BookManagementContext() : base("BookDBConnectionString")
        {
            Database.SetInitializer(new BookManagementDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new BookConfigurations());
            modelBuilder.Configurations.Add(new UserConfigurations());

            modelBuilder.Entity<Book>()
                .ToTable("Book");

            modelBuilder.Entity<User>()
                .ToTable("User");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
