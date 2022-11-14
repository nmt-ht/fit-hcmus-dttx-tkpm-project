﻿using BookManagement.Business.Helper;
using BookManagement.Client.Forms;
using BookManagement.Models;
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

    private void pnlTitleCustom_MouseClick(object sender, MouseEventArgs e)
    {
        NotifyParent(this.Parameter);
        FormSettingMaster.ResetBackColor();
        this.pnlTitleCustom.GradientTopColor = Color.FromArgb(107, 131, 239);
        this.pnlTitleCustom.GradientBottomColor = Color.FromArgb(195, 121, 225);
    }

    public int Index { get; set; }
    public Parameter Parameter { get; set; }
    public event SelectedParameterDelegate OnSelectedParameterDelegate;
    public void NotifyParent(Parameter parameter)
    {
        if (OnSelectedParameterDelegate != null)
        {
            ParameterEventArgs customerHandler = new ParameterEventArgs(parameter);
            OnSelectedParameterDelegate(customerHandler);
        }
    }
}
