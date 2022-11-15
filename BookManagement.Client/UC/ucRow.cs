using BookManagement.Client.Forms;

namespace BookManagement.Client.UC;
public partial class ucRow : UserControl
{
    FormSetting_1 FormSettingMaster = (FormSetting_1)Application.OpenForms["FormSetting"];
    public Color BackColorTop
    {
        get { return pnlTitleCustom.GradientTopColor; }
        set { pnlTitleCustom.GradientTopColor = value; }
    }

    public Color BackColorBottom
    {
        get { return pnlTitleCustom.GradientBottomColor; }
        set { pnlTitleCustom.GradientBottomColor = value; }
    }

    public ucRow()
    {
        InitializeComponent();
    }

    public void SetValues(string no, string name, string value, string type, string active)
    {
        lblNo.Text = no;
        lblName.Text = name;
        lblValue.Text = value;
        lblType.Text = type;
        lblActive.Text = active;
    }

    private void pnlTitleCustom_MouseClick(object sender, MouseEventArgs e)
    {
        FormSettingMaster.ResetBackColor();
        this.pnlTitleCustom.GradientTopColor = Color.FromArgb(107, 131, 239);
        this.pnlTitleCustom.GradientBottomColor = Color.FromArgb(195, 121, 225);
    }
}
