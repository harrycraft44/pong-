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
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Form2 s = new Form2();
            s.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.style)
            {
                case 0:
                    break;
                case 1:
                    panel1.BackColor = Color.White;
                    label1.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;

                    break;

            }
            //#0f0f0f
            if (Properties.Settings.Default.store) { } else {
                button2.BackColor = Color.FromArgb(15,15,15);
                toolTip1.SetToolTip(button2, "store closed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.store)
            {
                var s = new Form4();
                s.ShowDialog();
            }

        }
    }
}
