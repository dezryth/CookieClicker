using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CookieClicker
{
  public partial class frmCookieClicker : Form
  {

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;

    private const int MAXNUMCLICKSPERSEC = 10;
    private int numClicks = 0;

    public frmCookieClicker()
    {
      InitializeComponent();
      lblPrompt.Text += String.Format(" (Max {0})", MAXNUMCLICKSPERSEC);
    }

    public void DoMouseClick()
    {
      //Call the imported function with the cursor's current position
      uint X = (uint)Cursor.Position.X;
      uint Y = (uint)Cursor.Position.Y;
      mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
    }

    private void btnStart_Click(object sender, System.EventArgs e)
    {
      startClicking();
    }

    private void startClicking()
    {
      timer.Interval = 1000 / Int32.Parse(tbClicksPerSec.Text);
      timer.Enabled = true;
      lblStatus.Text = "RUNNING";
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      stopClicking();
    }

    private void stopClicking()
    {
      timer.Enabled = false;
      lblStatus.Text = "STOPPED";
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      DoMouseClick();
      numClicks++;
      lblNumClicks.Text = String.Format("Times Clicked: {0}", numClicks);
    }

    private void tbClicksPerSec_TextChanged(object sender, EventArgs e)
    {
      if (int.TryParse(tbClicksPerSec.Text, out int value))
      {
        if (value <= MAXNUMCLICKSPERSEC)
        {
          btnBegin.Enabled = true;
        }
      }
      else
      {
        btnBegin.Enabled = false;
      }
    }
  }
}
