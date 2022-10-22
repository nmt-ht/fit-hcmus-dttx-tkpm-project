using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms
{
    public partial class FormDelete : Form
    {
        public object Object { get; set; }
        public eAction Action { get; set; }
        public eObjectType ObjectType { get; set; }
        public FormDelete()
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
    }
}
