using Timer = System.Windows.Forms.Timer;

namespace BookManagement.Client.UC;
public partial class ucHome : UserControl
{
    private readonly Timer Timer = new Timer();
    public ucHome()
    {
        InitializeComponent();
        //Timer.Tick += TimerEventProcessor;
        //Timer.Interval = 1000;
        //Timer.Start();
    }

    private void ucDasboard_Load(object sender, EventArgs e)
    {
        lblDate.Text = DateTime.Now.ToLongDateString();
        lblTime.Text = DateTime.Now.ToShortTimeString();
    }

    private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
    {
        //lblTime.Text = DateTime.Now.ToShortTimeString();
    }
}
