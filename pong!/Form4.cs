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

namespace pong_
{
    public partial class Form4 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // width of ellipse
int nHeightEllipse // height of ellipse
);
        /// <summary>
        /// 
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uiupdate();
            this.Close();
        }
        private void uiupdate() {
            label1.Text = Properties.Settings.Default.points + " points";
            Properties.Settings.Default.Save();
            lmbuy.Show();
            lme.Show();
            dme.Show();
            if (!Properties.Settings.Default.lightmode)
            {
                lme.Hide();
                lmp.Show();
            }
            else {
                lmp.Hide();
            }

            switch (Properties.Settings.Default.style)
            {
                case 0:
                    dme.Hide();
                    break;
                case 1:
                    lmbuy.Hide();
                    lme.Hide();
                    break;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            uiupdate();

            label1.Text = Properties.Settings.Default.points+" points";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.points > 99)
            {
                Properties.Settings.Default.points -= 100;
                Properties.Settings.Default.lightmode = true;
                uiupdate();

            }
        }

        private void lme_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.style= 1;
            uiupdate();
        }

        private void dme_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.style = 0;
            uiupdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
    }
}
