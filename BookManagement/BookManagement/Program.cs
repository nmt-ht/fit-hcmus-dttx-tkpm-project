using BookManagement.DTO;
using BookManagement.Infrastructure;

namespace BookManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InitDatabase();
            Application.Run(new Dashboard());
        }

        private static void InitDatabase()
        {
            string message = "Have you set up database?";
            string title = "Set up Database";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                using (var ctx = new BookManagementContext())
                {
                    try
                    {
                        var book = new Book();
                        ctx.Books.Add(book);
                        ctx.SaveChanges();
                    }
                    catch{}
                }
            }
        }
    }
}