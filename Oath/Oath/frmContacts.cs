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
    public partial class frmContacts : Form
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
        public frmContacts()
        {
            InitializeComponent();
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            frmMain objMain = new frmMain();
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            objMain.Show();
            this.Hide();
            
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            
            frmAnalytics objAna = new frmAnalytics();
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
            objAna.Show();
            this.Hide();
            
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            
            frmCalendar objCal = new frmCalendar();
            PnlNav.Height = btnCalendar.Height;
            PnlNav.Top = btnCalendar.Top;
            PnlNav.Left = btnCalendar.Left;
            objCal.Show();
            this.Hide();
            
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
        }
    }
}
