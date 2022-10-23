namespace BookManagement.Client.Dialog
{
    public partial class DeleteDialog : Form
    {
        public DeleteDialog()
        {
            InitializeComponent();
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

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
