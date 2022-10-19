using Book.Infrastructure.DataAccess.Data;
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var users = this.userData.GetUsers();
        }
    }
}