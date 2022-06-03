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
    public partial class frmCalendar : Form
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
        public frmCalendar()
        {
            InitializeComponent();
            PnlNav.Height = btnCalendar.Height;
            PnlNav.Top = btnCalendar.Top;
            PnlNav.Left = btnCalendar.Left;
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            frmContacts objContact = new frmContacts();
            objContact.Show();
            this.Hide();
            
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
            frmAnalytics objAna = new frmAnalytics();
            objAna.Show();
            this.Hide();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            frmMain objMain = new frmMain();
            objMain.Show();
            this.Hide();
            
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnCalendar.Height;
            PnlNav.Top = btnCalendar.Top;
            PnlNav.Left = btnCalendar.Left;
        }
    }
}
