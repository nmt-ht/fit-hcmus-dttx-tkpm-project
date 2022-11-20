using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows.Forms;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog.Employee
{
    public partial class EmployeeDetailsDialog : Form
    {
        public User User { get; set; }
        public eAction Action { get; set; }

        public EmployeeDetailsDialog()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            if (Action == eAction.Edit) 
            {
                ucEmployeeInfo.BindData(User);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User = ucEmployeeInfo.GetData();
            if (string.IsNullOrEmpty(User.UserName) ||
                string.IsNullOrEmpty(User.FirstName) ||
                string.IsNullOrEmpty(User.LastName) ||
                string.IsNullOrEmpty(User.Password))
            {
                MessageBox.Show("All fields are mandatory!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
