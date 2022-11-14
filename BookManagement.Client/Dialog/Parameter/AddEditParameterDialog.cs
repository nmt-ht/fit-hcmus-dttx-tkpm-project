using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog;

public partial class AddEditParameterDialog : Form
{
    private eAction Action { get; set; }
    public Parameter Parameter { get; set; }
    public AddEditParameterDialog()
    {
        InitializeComponent();
    }

    public void SetParameter(Parameter para, eAction action)
    {
        Parameter = para;
        Action = action;
    }

    public void DataBind()
    {
        if (Parameter is not null && Action == eAction.Edit)
            BindParameterData(Parameter);
    }

    private void BindParameterData(Parameter parameter)
    {
        txtName.Text = parameter.Name;
        txtValue.Text = parameter.Value.ToString();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateBeforeSave())
        {
            var newParameter = new Parameter
            {
                Name = txtName.Text,
                Value = txtValue.Text,
            };
            newParameter.Id = Action == eAction.Edit ? Parameter.Id : Guid.Empty;
            Parameter = newParameter;
            DialogResult = DialogResult.OK;
        }
        else
        {
            DisplayNotification(eMessageType.Warning, "Add/Edit Parameter", "Please enter valid data.");
        }
    }

    private bool ValidateBeforeSave()
    {
        return !ValidateParamName() || !ValidateValue();
    }

    private bool ValidateValue()
    {
        var result = true;
        if (string.IsNullOrEmpty(txtValue.Text) || decimal.Parse(txtValue.Text) <= 0)
        {
            errorProviderParam.SetError(txtValue, "Value cannot be empty.");
            result = false;
        }
        else { errorProviderParam.SetError(txtValue, ""); }
        return result;
    }

    private bool ValidateParamName()
    {
        var result = true;
        if (string.IsNullOrEmpty(txtName.Text))
        {
            errorProviderParam.SetError(txtName, "Parameter name cannot be empty.");
            result = false;
        }
        else { errorProviderParam.SetError(txtName, ""); }
        return result;
    }

    private void DisplayNotification(eMessageType messageType, string title, string message)
    {
        using (var messageBox = new MessageBoxDialog())
        {
            messageBox.SetParametters(title, message, messageType);
            messageBox.DataBind();
            messageBox.ShowDialog();
        }
    }
}
