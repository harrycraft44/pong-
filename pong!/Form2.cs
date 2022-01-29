using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong_
{
    public partial class Form2 : Form
    {    public static int count = 0;
        public static int month = 0;

        public Form2()
        { 
            Random rnd = new Random();

            InitializeComponent();
            month = rnd.Next(10, 16);  

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count + 1;
            if (count == month)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void P1_Click(object sender, EventArgs e)
        {

        }
    }
}
