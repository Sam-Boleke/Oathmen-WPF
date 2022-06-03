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
    public partial class frmMain : Form
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

        public frmMain()
        {
            InitializeComponent();
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            //btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            //btnDashboard.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
            //btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
            //richTextBox1.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnCalendar.Height;
            PnlNav.Top = btnCalendar.Top;
            PnlNav.Left = btnCalendar.Left;
            //btnCalendar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            //btnContacts.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            PnlNav.Left = btnSettings.Left;
            //btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            //btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            //btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            //btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContacts_Leave(object sender, EventArgs e)
        {
            //btnContacts.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAnalytics_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            frmAnalytics objFormAnalytics = new frmAnalytics();
            objFormAnalytics.Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelPlay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {

        }

        private void btnContacts_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            frmContacts objCont = new frmContacts();
            objCont.Show();
            this.Hide();
            
        }

        private void btnCalendar_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = btnContacts.Height;
            PnlNav.Top = btnContacts.Top;
            PnlNav.Left = btnContacts.Left;
            frmCalendar objFormCalendr = new frmCalendar();
            objFormCalendr.Show();
            this.Hide();
            
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
