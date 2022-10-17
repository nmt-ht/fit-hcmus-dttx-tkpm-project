using BookManagement.DTO;
using System.Data.Entity;

namespace BookManagement.Infrastructure
{
    public class BookManagementDBInitializer: DropCreateDatabaseAlways<BookManagementContext>
    {
        protected override void Seed(BookManagementContext context)
        {
            base.Seed(context);
        }
    }
}
