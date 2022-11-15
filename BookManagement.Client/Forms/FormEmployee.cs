using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;

namespace BookManagement.Client.Forms;

public partial class FormEmployee : Form
{
    private readonly IUserBiz _userBiz;
    private ucLayout ucLayout = new ucLayout();
    private IEnumerable<User> _users = new List<User>();

    public FormEmployee(IUserBiz userBiz)
    {
        InitializeComponent();
        _userBiz = userBiz;

        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.Dock = DockStyle.Top;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.OnSearch += UcLayout_OnSearch;
        ucLayout.OnReloadDataDelegate += UcLayout_OnReloadDataDelegate;
        ucLayout.OnDeleteItemDelegate += UcLayout_OnDeleteItemDelegate;
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

    private void BindingUsers(IEnumerable<User> users)
    {
        ucLayout.flowLayoutBooks.Controls.Clear();

        if (users.Any())
        {
            var headerRow = new ucRow();
            headerRow.Margin = new Padding(5);
            headerRow.SetValues("Id", "Fullname", "Username", "Type", "Active");
            ucLayout.flowLayoutBooks.Controls.Add(headerRow);

            foreach (var user in users)
            {
                var row = new ucRow();
                row.AutoSize = false;
                row.Margin = new Padding(5);
                row.SetValues(user.Id.ToString(), user.FullName, user.UserName, user.Type.ToString(), (!user.IsDeleted).ToString());
                ucLayout.flowLayoutBooks.Controls.Add(row);
            }
        }
    }

    private void UcLayout_OnSearch(SearchEventArgs e)
    {
        var selectedUsers = _users
            .Where(u => u.FullName.Contains(e.SearchText, StringComparison.OrdinalIgnoreCase) ||
                u.UserName.Contains(e.SearchText, StringComparison.OrdinalIgnoreCase))
            .ToList();

        BindingUsers(selectedUsers);
    }

    private void UcLayout_OnDeleteItemDelegate(DeleteItemEventArgs deleteItemEvent)
    {
        
    }

    private void UcLayout_OnReloadDataDelegate(ReloadDataEventArgs reload)
    {
        BindingUsers(_users);
    }
}
