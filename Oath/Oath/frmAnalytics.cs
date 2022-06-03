using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Oath
{
    public partial class frmAnalytics : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRet,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public frmAnalytics()
        {
            InitializeComponent();
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            frmMain objFormMain = new frmMain();
            objFormMain.Show();
            this.Hide();
            
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnCalendar.Height;
            PnlNav.Top = btnCalendar.Top;
            PnlNav.Left = btnCalendar.Left;
            frmCalendar objCal = new frmCalendar();
            objCal.Show();
            this.Hide();
           
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            frmContacts objCon = new frmContacts();
            objCon.Show();
            this.Hide();
            
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
        }
    }
}
