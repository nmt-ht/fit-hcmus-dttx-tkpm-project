using BookManagement.Business.Helper;
using BookManagement.Client.Forms;
using BookManagement.Models;
using System.Data;
using static BookManagement.Business.Helper.ParameterDelegateHandler;

namespace BookManagement.Client.UC;
public partial class ucRow : UserControl
{
    FormSetting FormSettingMaster = (FormSetting)Application.OpenForms["FormSetting"];
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

    public void DataBind()
    {
        if (Parameter is not null)
        {
            lblNo.Text = Index.ToString();
            lblName.Text = Parameter.Name?.Length > 50 ? Parameter.Name?.Substring(0, 50) + "..." : Parameter.Name;
            lblValue.Text = Parameter.Value.ToString();
            lblType.Text = Parameter.ParameterType.ToString();
            lblActive.Text = Parameter.IsActive.ToString();
        }
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
        NotifyParent(this.Parameter);
        OnRowSelected?.Invoke(new string[] { lblNo.Text, lblName.Text, lblValue.Text, lblType.Text, lblActive.Text });
        FormSettingMaster?.ResetBackColor();
        this.pnlTitleCustom.GradientTopColor = Color.FromArgb(107, 131, 239);
        this.pnlTitleCustom.GradientBottomColor = Color.FromArgb(195, 121, 225);
    }

    public int Index { get; set; }
    public Parameter Parameter { get; set; }
    public event SelectedParameterDelegate OnSelectedParameterDelegate;
    public event SelectedRowDelegate OnRowSelected;
    public void NotifyParent(Parameter parameter)
    {
        if (OnSelectedParameterDelegate != null)
        {
            ParameterEventArgs customerHandler = new ParameterEventArgs(parameter);
            OnSelectedParameterDelegate(customerHandler);
        }
    }
}
