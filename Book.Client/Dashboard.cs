using Book.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement
{
    public partial class Dashboard : Form
    {
        IUserData userData;
        public Dashboard(IUserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            var users = await this.userData.GetUsers();
            if(users is not null)
            {

            }
        }
    }
}