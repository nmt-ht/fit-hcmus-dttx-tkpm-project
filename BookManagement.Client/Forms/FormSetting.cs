using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormSetting : Form
{
    private readonly IParameterBiz _parameterBiz;
    private IList<Parameter> Parameters { get; set; }
    private Parameter SelectedParameter { get; set; }

    private bool IsEdited
    {
        get { return this.SelectedParameter is not null ? true : false; }
    }
    public FormSetting(IParameterBiz parameterBiz)
    {
        InitializeComponent();
        _parameterBiz = parameterBiz;
        flpSetting.AutoScroll = true;
        flpSetting.AutoSize = true;
        flpSetting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpSetting.WrapContents = true;
    }

    private void DataBind()
    {
        Parameters = GetParameters();
        BindDataToControl();
    }

    private void BindDataToControl()
    {
        if (Parameters.Any())
        {
            flpSetting.Controls.Clear();

            for (int i = 0; i < Parameters.Count; i++)
            {
                ucRow row = new ucRow()
                {
                    Parameter = Parameters[i],
                    Index = i + 1,
                    AutoSize = false,
                    Width = (int)SystemParameters.FullPrimaryScreenWidth - 200,
                };
                row.OnSelectedParameterDelegate += ucRow_OnSelected;

                row.DataBind();
                flpSetting.Controls.Add(row);
            }
        }
    }

    private void FormCustomer_Load(object sender, EventArgs e)
    {
        DataBind();
    }

    internal void ResetBackColor()
    {
        foreach (var item in flpSetting.Controls.OfType<ucRow>())
        {
            item.BackColorTop = Color.FromArgb(142, 195, 176);
            item.BackColorBottom = Color.FromArgb(141, 114, 225);
        }
    }

    private IList<Parameter> GetParameters()
    {
        return _parameterBiz.GetParameters().ToList();
    }

    private void ucRow_OnSelected(ParameterEventArgs parameterEvent)
    {
        SelectedParameter = parameterEvent.Parameter;
        UpdateButtonFunction();
    }

    private void UpdateButtonFunction()
    {
        if (this.IsEdited)
        {
            btnEdit.Enabled = btnDelete.Enabled = true;
            btnEdit.BackColor = btnDelete.BackColor = Color.Lavender;
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Linen;
        }
        else
        {
            btnEdit.Enabled = btnDelete.Enabled = false;
            btnEdit.BackColor = btnDelete.BackColor = Color.Linen;
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.Lavender;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using(var addParaDialog = new AddEditParameterDialog())
        {
            addParaDialog.SetParameter(null, eAction.Add);
            if(addParaDialog.ShowDialog() == DialogResult.OK)
            {
                _parameterBiz.AddNewParameter(addParaDialog.Parameter);
                DisplayNotification(eMessageType.Info, "Add Parameter", "Added new parameter successfully.");
                DataBind();
            }
        }
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

    private void btnEdit_Click(object sender, EventArgs e)
    {
        using (var addParaDialog = new AddEditParameterDialog())
        {
            addParaDialog.SetParameter(SelectedParameter, eAction.Edit);
            addParaDialog.DataBind();
            if (addParaDialog.ShowDialog() == DialogResult.OK)
            {
                _parameterBiz.UpdateParameter(addParaDialog.Parameter);
                DisplayNotification(eMessageType.Info, "Edit Parameter", "Edited parameter successfully.");
                DataBind();
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        using (var deleteDialog = new DeleteDialog())
        {
            if (deleteDialog.ShowDialog() == DialogResult.OK)
            {
                _parameterBiz.DeleteParameter(SelectedParameter.Id);
                DisplayNotification(eMessageType.Info, "Delete Parameter", "Deleted parameter successfully.");
                DataBind();
            }
        }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        DataBind();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        OnSearch();
    }
    
    private void OnSearch()
    {
        var textSearch = txtSearchText.Text.ToLower();
        if (!string.IsNullOrEmpty(textSearch))
        {
            var searchResults = this.Parameters.Where(x => x.Name.ToLower().Contains(textSearch.ToLower())
                                                    || x.Value.ToLower().Contains(textSearch.ToLower())).ToList();
            this.Parameters = searchResults;
            BindDataToControl();
        }
        else
        {
            DisplayNotification(eMessageType.Warning, "Search", "Please enter your text search.");
        }
    }

    private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            OnSearch();
        }
    }
}
