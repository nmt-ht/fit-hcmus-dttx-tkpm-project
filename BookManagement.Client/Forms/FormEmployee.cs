using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Client.Dialog.Employee;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;

namespace BookManagement.Client.Forms;

public partial class FormEmployee : Form
{
    private readonly IUserBiz _userBiz;
    private ucLayout ucLayout = new ucLayout();
    private IEnumerable<User> _users = new List<User>();
    private User selectedUser;

    public FormEmployee(IUserBiz userBiz)
    {
        InitializeComponent();
        _userBiz = userBiz;

        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.LayoutType = null;
        ucLayout.Dock = DockStyle.Top;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.OnSearch += UcLayout_OnSearch;
        ucLayout.OnReloadDataDelegate += UcLayout_OnReloadDataDelegate;
        ucLayout.OnDeleteItemDelegate += UcLayout_OnDeleteItemDelegate;
        ucLayout.OnAddItem += UcLayout_OnAddItem;
        ucLayout.OnEditItem += UcLayout_OnEditItem;
    }

    private void FormEmployee_Load(object sender, EventArgs e)
    {
        DataBind();
    }

    private void DataBind()
    {
        _users = _userBiz.GetUsers();
        BindingUsers(_users);

        pnlEmployee.Controls.Add(ucLayout);
    }

    private void UpdateGrid()
    {
        _users = _userBiz.GetUsers();
        BindingUsers(_users);
    }

    private void BindingUsers(IEnumerable<User> users)
    {
        ucLayout.flowLayoutBooks.Controls.Clear();

        if (users.Any())
        {
            var headerRow = new ucRow();
            headerRow.Width = (int)SystemParameters.FullPrimaryScreenWidth - 200;
            headerRow.Margin = new Padding(5);
            headerRow.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            headerRow.SetValues("Id", "Fullname", "Username", "Type", "Active");
            ucLayout.flowLayoutBooks.Controls.Add(headerRow);

            foreach (var user in users)
            {
                var row = new ucRow();
                row.Width = (int)SystemParameters.FullPrimaryScreenWidth - 200;
                row.Margin = new Padding(5);
                row.SetValues(user.Id.ToString(), user.FullName, user.UserName, user.Type.ToString(), (!user.IsDeleted).ToString());
                row.OnRowSelected += new SelectedRowDelegate(Row_OnSelected);
                ucLayout.flowLayoutBooks.Controls.Add(row);
            }
        }
    }

    private void UcLayout_OnSearch(SearchEventArgs e)
    {
        var filteredUsers = _users
            .Where(u => u.FullName.Contains(e.SearchText, StringComparison.OrdinalIgnoreCase) ||
                u.UserName.Contains(e.SearchText, StringComparison.OrdinalIgnoreCase))
            .ToList();

        BindingUsers(filteredUsers);
    }

    private void UcLayout_OnDeleteItemDelegate(DeleteItemEventArgs deleteItemEvent)
    {
        var deleteConfirmDialog = new DeleteDialog();
        if (deleteConfirmDialog.ShowDialog() == DialogResult.OK) 
        {
            if (this.selectedUser.Type == Models.DataType.eUserType.User) 
            {
                _userBiz.DeleteUser(this.selectedUser.Id);
                UpdateGrid();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The admin cannot be deleted!");
            }
            
        }
    }

    private void UcLayout_OnReloadDataDelegate(ReloadDataEventArgs reload)
    {
        BindingUsers(_users);
    }

    private void UcLayout_OnEditItem(EventArgs eventArgs)
    {
        var editDialog = new EmployeeDetailsDialog();
        editDialog.lblTitle.Text = "Edit Employee";
        editDialog.User = this.selectedUser;
        editDialog.Action = DataType.eAction.Edit;
        editDialog.BindData();
        if (editDialog.ShowDialog() == DialogResult.OK)
        {
            _userBiz.UpdateUser(editDialog.User);
            UpdateGrid();
        }
    }



    private void UcLayout_OnAddItem(EventArgs eventArgs)
    {
        var addDialog = new EmployeeDetailsDialog();
        addDialog.lblTitle.Text = "Add New Employee";
        addDialog.Action = DataType.eAction.Add;
        if (addDialog.ShowDialog() == DialogResult.OK) 
        {
            _userBiz.AddUser(addDialog.User);
            UpdateGrid();
        }
    }

    private void Row_OnSelected(string[] items)
    {
        foreach (var item in ucLayout.flowLayoutBooks.Controls.OfType<ucRow>())
        {
            item.BackColorTop = Color.FromArgb(142, 195, 176);
            item.BackColorBottom = Color.FromArgb(141, 114, 225);
        }

        this.selectedUser = _userBiz.GetUserByUserName(items[2]);
        if (selectedUser != null)
        {
            ucLayout.ShowEditActions();
        }
        else
        {
           ucLayout.HideEditActions();
        }
        
    }
}
