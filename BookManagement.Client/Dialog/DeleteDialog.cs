using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class DeleteDialog : Form
    {
        public object Object { get; set; }
        public eAction Action { get; set; }
        public eObjectType ObjectType { get; set; }
        public DeleteDialog()
        {
            InitializeComponent();
        }
        public void SetParametters(object objectName, eAction action, eObjectType objectType)
        {
            Object = objectName;
            Action = action;
            ObjectType = objectType;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
    }
}
