using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms
{
    public partial class FormMessageBox : Form
    {
        private string Title { get;set; }
        private string Message { get; set; }
        private eMessageType MessageType { get; set; }
        public FormMessageBox()
        {
            InitializeComponent();
        }
        public void SetParametters(string title, string message, eMessageType messageType)
        {
            this.Title = title;
            this.Message = message;
            this.MessageType = messageType;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void DataBind()
        {
            switch (MessageType)
            {
                case eMessageType.Info:
                    this.picBox.Image = Properties.Resources.message_info;
                    break;
                case eMessageType.Warning:
                    this.picBox.Image = Properties.Resources.message_warning;
                    break;
            }
            lblTitle.Text = this.Title;
            lblMessage.Text = this.Message;
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
