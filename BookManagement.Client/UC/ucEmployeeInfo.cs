
using BookManagement.Business.Helper;
using BookManagement.Models;
using System.Windows.Media.TextFormatting;
using static BookManagement.Client.DataType;
using static BookManagement.Models.DataType;

namespace BookManagement.Client.UC
{
    public partial class ucEmployeeInfo : UserControl
    {
        private Guid _id;
        public ucEmployeeInfo()
        {
            InitializeComponent();
            cboType.DataSource = Enum.GetValues(typeof(eUserType)).Cast<eUserType>().ToList();
        }

        public void BindData(User user)
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
            cboType.SelectedItem = user.Type;
            _id = user.Id;
        }

        public User GetData()
        {
            return new User
            {
                Id = _id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Type = (eUserType)cboType.SelectedValue
            };
        }
    }
}
