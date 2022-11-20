using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Models;
using static BookManagement.Business.Helper.BookDelegateHandler;
using static BookManagement.Business.Helper.CustomerDelegateHandler;
using static BookManagement.Business.Helper.DeleteItemDelegateHandler;
using static BookManagement.Business.Helper.OrderDelegateHandler;
using static BookManagement.Business.Helper.ReloadDataDelegateHandler;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.UC;
public partial class ucLayout : UserControl
{
    public IParameterBiz ParameterBiz { get; set; }
    public IList<Book> Books { get; set; } = new List<Book>();
    public IList<Customer> Customers { get; set; } = new List<Customer>();
    public IList<Receipt> Receipts { get; set; } = new List<Receipt>();
    public eLayoutType? LayoutType { get; set; }
    public Book SelectedBook { get; set; }
    public Customer SelectedCustomer { get; set; }
    private bool IsEdited { get; set; } = false;
    private int LimitInputValue { get; set; } = 150;

    public event ReloadDataDelegate OnReloadDataDelegate;
    public event DeleteItemDelegate OnDeleteItemDelegate;
    public event SelectedBookDelegate OnAddBookDelegate;
    public event SelectedBookDelegate OnEditBookDelegate;
    public event SelectedCustomerDelegate OnAddCustomerDelegate;
    public event SelectedCustomerDelegate OnEditCustomerDelegate;
    public event OrderBookDelegate OnOrderBookDelegate;
    public event SearchHandler OnSearch;
    public event AddItemDelegate OnAddItem;
    public event EditItemDelegate OnEditItem;
    
    public ucLayout()
    {
        InitializeComponent();
        flowLayoutBooks.AutoScroll = true;
        flowLayoutBooks.AutoSize = true;
        flowLayoutBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutBooks.Location = new Point(0, 10);
        flowLayoutBooks.WrapContents = true;
    }

    public void DataBind()
    {
        switch (LayoutType)
        {
            case eLayoutType.Book:
                BindDataForBook();
                if(ParameterBiz is not null)
                {
                    //this.LimitInputValue = ParameterBiz.Get
                }
                break;
            case eLayoutType.Customer:
                BindDataForCustomer();
                break;
            case eLayoutType.Receipt:
                BindDataForInvoices();
                break;
        }
    }

    private void BindDataForInvoices()
    {
        if (Receipts.Any())
        {
            flowLayoutBooks.Controls.Clear();

            foreach (var receipt in Receipts)
            {
                UcReceiptInfo ucCustomerInfo = new UcReceiptInfo();
                ucCustomerInfo.Receipt = receipt;
                //ucCustomerInfo.DataBind();
                ucCustomerInfo.Margin = new Padding(20);
                //ucCustomerInfo.OnSelectedCustomerDelegate += UcCustomerInfo_OnSelectedCustomerDelegate;
                flowLayoutBooks.Controls.Add(ucCustomerInfo);
            }
        }
    }

    private void BindDataForCustomer()
    {
        if (Customers.Any())
        {
            flowLayoutBooks.Controls.Clear();

            foreach (var customer in Customers)
            {
                ucCustomerInfo ucCustomerInfo = new ucCustomerInfo();
                ucCustomerInfo.Customer = customer;
                ucCustomerInfo.DataBind();
                ucCustomerInfo.Margin = new Padding(20);
                ucCustomerInfo.OnSelectedCustomerDelegate += UcCustomerInfo_OnSelectedCustomerDelegate;
                flowLayoutBooks.Controls.Add(ucCustomerInfo);
            }
        }
    }
    private void BindDataForBook()
    {
        if (Books.Any())
        {
            flowLayoutBooks.Controls.Clear();

            foreach (var book in Books)
            {
                ucBookInfo ucBookInfo = new ucBookInfo();
                ucBookInfo.Book = book;
                ucBookInfo.DataBind();
                ucBookInfo.Margin = new Padding(10);
                ucBookInfo.OnSelectedBookDelegate += UcBookInfo_OnSelectedBookDelegate;
                ucBookInfo.OnOrderBookDelegate += UcBookInfo_OnOrderBookDelegate; ;
                flowLayoutBooks.Controls.Add(ucBookInfo);
            }
        }
    }

    private void UcBookInfo_OnOrderBookDelegate(OrderCustomEventArgs orderCustomEventArgs)
    {
        OnOrderBookDelegate.Invoke(orderCustomEventArgs);
    }

    private void UcCustomerInfo_OnSelectedCustomerDelegate(CustomerCustomEventArgs customerCustomEventArgs)
    {
        var selectedCustomers = flowLayoutBooks.Controls.Cast<ucCustomerInfo>().Where(uc => uc.IsSelected).ToList();
        IsEdited = selectedCustomers.Any() ? true : false;

        if (customerCustomEventArgs is not null)
        {
            if (customerCustomEventArgs.IsSelected && SelectedCustomer is not null && customerCustomEventArgs.Customer != SelectedCustomer)
            {
                var previouseSelectedBook = selectedCustomers.Where(x => x.Customer.Id == SelectedCustomer.Id).FirstOrDefault();
                if (previouseSelectedBook is not null)
                    previouseSelectedBook.IsSelected = false;
            }

            SelectedCustomer = customerCustomEventArgs.Customer;
        }

        UpdateButtonFunction();
    }

    private void UcBookInfo_OnSelectedBookDelegate(BookCustomEventArgs bookCustomEvent)
    {
        var selectedBooks = flowLayoutBooks.Controls.Cast<ucBookInfo>().Where(uc => uc.IsSelected).ToList();
        IsEdited = selectedBooks.Any() ? true : false;

        if (bookCustomEvent is not null)
        {
            if (bookCustomEvent.IsSelected && SelectedBook is not null && bookCustomEvent.Book != SelectedBook)
            {
                var previouseSelectedBook = selectedBooks.Where(x => x.Book.Name == SelectedBook.Name).FirstOrDefault();
                if (previouseSelectedBook is not null)
                    previouseSelectedBook.IsSelected = false;
            }

            SelectedBook = bookCustomEvent.Book;
        }

        UpdateButtonFunction();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        switch (LayoutType)
        {
            case eLayoutType.Book:
                using (var addBook = new AddEditBookDialog())
                {
                    addBook.SetParametters(new Book(), eAction.Add, this.Books, LimitInputValue, 300);
                    addBook.DataBind();
                    if (addBook.ShowDialog() == DialogResult.OK)
                    {
                        BookActionCallback(addBook.BookHandler, eAction.Add);
                    }
                }
                break;
            case eLayoutType.Customer:
                using (var newCustomer = new AddEditCustomerDialog())
                {
                    newCustomer.lblTitle.Text = "Create Customer";
                    newCustomer.DataBind();
                    if (newCustomer.ShowDialog() == DialogResult.OK)
                    {
                        CustomerActionCallback(newCustomer.Customer, eAction.Add);
                    }
                }
                break;
        }
        OnAddItem?.Invoke(e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        switch (LayoutType)
        {
            case eLayoutType.Book:
                if (SelectedBook is not null)
                {
                    using (var editBook = new AddEditBookDialog())
                    {
                        editBook.SetParametters(SelectedBook, eAction.Edit, new List<Book>());
                        editBook.DataBind();
                        if (editBook.ShowDialog() == DialogResult.OK)
                        {
                            BookActionCallback(editBook.BookHandler, eAction.Edit);
                        }
                    }
                }
                break;
            case eLayoutType.Customer:
                if (SelectedCustomer is not null)
                {
                    using (var editCustomer = new AddEditCustomerDialog())
                    {
                        editCustomer.lblTitle.Text = "Edit Customer";
                        editCustomer.SetParametters(SelectedCustomer, eAction.Edit);
                        editCustomer.DataBind();
                        if (editCustomer.ShowDialog() == DialogResult.OK)
                        {
                            CustomerActionCallback(editCustomer.Customer, eAction.Edit);
                        }
                    }
                }
                break;
        }
        OnEditItem?.Invoke(e);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        switch (LayoutType)
        {
            case eLayoutType.Book:
                if (SelectedBook is not null)
                {
                    using (var deleteDialog = new DeleteDialog())
                    {
                        if (deleteDialog.ShowDialog() == DialogResult.OK)
                        {
                            BookActionCallback(SelectedBook, eAction.Delete);
                        }
                    }
                }
                break;
            case eLayoutType.Customer:
                if (SelectedCustomer is not null)
                {
                    using (var deleteDialog = new DeleteDialog())
                    {
                        if (deleteDialog.ShowDialog() == DialogResult.OK)
                        {
                            CustomerActionCallback(SelectedCustomer, eAction.Delete);
                        }
                    }
                }
                break;
        }
        OnDeleteItemDelegate?.Invoke(new DeleteItemEventArgs(Guid.Empty));
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

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var textSearch = txtSearchText.Text.ToLower();
        if (!string.IsNullOrEmpty(textSearch))
        {
            switch (LayoutType)
            {
                case eLayoutType.Book:
                    var searchResults = this.Books.Where(x => x.Name.ToLower().Contains(textSearch)
                                         || x.Author.ToLower().Contains(textSearch)
                                         || x.Description.ToLower().Contains(textSearch)).ToList();
                    this.Books = searchResults;
                    break;
                case eLayoutType.Customer:
                    var customerSearchRes = this.Customers.Where(x => x.FullName.ToLower().Contains(textSearch)
                                         || x.FirstName.ToLower().Contains(textSearch)
                                         || x.LastName.ToLower().Contains(textSearch)).ToList();
                    this.Customers = customerSearchRes;
                    break;
                
            }
         
            DataBind();
            OnSearch?.Invoke(new SearchEventArgs(textSearch));
        }
        else
        {
            DisplayNotification(eMessageType.Warning, "Search", "Please enter your text search.");
        }
    }

    private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnSearch_Click(sender, e);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        OnReloadData();
    }

    private void OnReloadData()
    {
        if (OnReloadDataDelegate != null)
        {
            ReloadDataEventArgs reloadData = new ReloadDataEventArgs(true);
            OnReloadDataDelegate(reloadData);
        }
    }

    private void BookActionCallback(Book book, eAction action)
    {
        switch (action)
        {
            case eAction.Add:
                if (OnAddBookDelegate != null)
                {
                    BookCustomEventArgs bookCustomEvent = new BookCustomEventArgs(book);
                    OnAddBookDelegate(bookCustomEvent);
                }
                break;
            case eAction.Edit:
                if (OnEditBookDelegate != null)
                {
                    BookCustomEventArgs bookCustomEvent = new BookCustomEventArgs(book);
                    OnEditBookDelegate(bookCustomEvent);
                }
                break;
            case eAction.Delete:
                if (OnDeleteItemDelegate != null)
                {
                    DeleteItemEventArgs deleteItemEventArgs = new DeleteItemEventArgs(book.Id);
                    OnDeleteItemDelegate(deleteItemEventArgs);
                }
                break;
        }
    }

    private void CustomerActionCallback(Customer customer, eAction action)
    {
        switch (action)
        {
            case eAction.Add:
                if (OnAddCustomerDelegate != null)
                {
                    CustomerCustomEventArgs customerCustomEventArgs = new CustomerCustomEventArgs(customer);
                    OnAddCustomerDelegate(customerCustomEventArgs);
                }
                break;
            case eAction.Edit:
                if (OnEditCustomerDelegate != null)
                {
                    CustomerCustomEventArgs customerCustomEventArgs = new CustomerCustomEventArgs(customer);
                    OnEditCustomerDelegate(customerCustomEventArgs);
                }
                break;
            case eAction.Delete:
                if (OnDeleteItemDelegate != null)
                {
                    DeleteItemEventArgs deleteItemEventArgs = new DeleteItemEventArgs(customer.Id);
                    OnDeleteItemDelegate(deleteItemEventArgs);
                }
                break;
        }
    }

    public void ShowEditActions()
    {
        btnEdit.Enabled = btnDelete.Enabled = true;
        btnEdit.BackColor = btnDelete.BackColor = Color.Lavender;
    }

    public void HideEditActions()
    {
        btnEdit.Enabled = btnDelete.Enabled = false;
        btnEdit.BackColor = btnDelete.BackColor = Color.Linen;
    }
}
