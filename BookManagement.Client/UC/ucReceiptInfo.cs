using BookManagement.Models;
using static BookManagement.Business.Helper.BookDelegateHandler;
using static BookManagement.Business.Helper.OrderDelegateHandler;

namespace BookManagement.Client.UC;
public partial class UcReceiptInfo : UserControl
{
    public Receipt Receipt { get; set; }
    public bool IsSelected { get; set; } = false;
    public event SelectedBookDelegate OnSelectedBookDelegate;
    public event OrderBookDelegate OnOrderBookDelegate;

    public UcReceiptInfo()
    {
        InitializeComponent();
    }
}
