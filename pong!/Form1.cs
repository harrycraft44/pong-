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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public bool up = true;
        public bool left = false;
        public bool messagebox = false;
        public int[] scores = { 0, 0 };
        public int over = 0;
        public int randi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            scoresupdate();


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void scoresupdate() {
            label1.Text = scores[0] + "|" + scores[1];


        }
        private void aiupdate() {
            Random rnd = new Random();
     
            if (ball.Location.X > ai.Location.X)
            {
                scores[0] = scores[0] + 1;
                    messagebox = true;
                    restart();
                scoresupdate();
            }
            else if(ball.Location.X < P1.Location.X)
            {

                scores[1] = scores[1] + 1;
                    restart();
                scoresupdate();
            }
            if (left)
            {
                ball.Location = new Point(ball.Location.X + 5, ball.Location.Y + randi + over);
                if (ai.Location.X < ball.Location.X && ai.Bounds.IntersectsWith(ball.Bounds))
                {

                    left = false;
                    randi = rnd.Next(-5, 5);

                }

            }
            else {
                ball.Location = new Point(ball.Location.X - 5, ball.Location.Y + randi + over);
                if (P1.Location.X < ball.Location.X && P1.Bounds.IntersectsWith(ball.Bounds))
                {

                    left = true;
                    randi = rnd.Next(-5, 5);

                }
            }
            if (ed2.Bounds.IntersectsWith(ball.Bounds))
            {
                over = 5;
                randi = 5;
            } else if (ed.Bounds.IntersectsWith(ball.Bounds)) {
                over = 5;
                randi = -5;
            }
            else {

            }
            if (ball.Location.X == ai.Location.X || ball.Location.X - 5 == ai.Location.X || ball.Location.X + 5 == ai.Location.X) { }
            else{
                if (up)
                {

                    if (end2.Location.Y > ai.Location.Y)
                    {
                        ai.Location = new Point(ai.Location.X, ai.Location.Y + 5);
                    }
                    else if (end1.Location.Y < ai.Location.Y)
                    {
                        ai.Location = new Point(ai.Location.X, ai.Location.Y - 5);
                        up = false;
                    }

                }
                else
                {
                    if (end1.Location.Y < ai.Location.Y)
                    {
                        ai.Location = new Point(ai.Location.X, ai.Location.Y - 5);
                    }
                    else if (end2.Location.Y > ai.Location.Y)
                    {
                        ai.Location = new Point(ai.Location.X, ai.Location.Y + 5);
                        up = true;
                    }

                } 
            }

        }
        private void move(int add) {


            for (int i = 0; i < 10; i++)
            {
                P1.Location = new Point(P1.Location.X, P1.Location.Y + add);
                Task.Delay(1);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (end2.Location.Y > P1.Location.Y)
                {
                    move(1);
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (end1.Location.Y < P1.Location.Y)
                {
                    move(-1);
                }

            } else if (e.KeyCode == Keys.R) { restart();

            } else if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            aiupdate();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!ed2.Bounds.IntersectsWith(ball.Bounds))
            {
                over = 0;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restart()
        {
            ball.Location = start.Location;
            left = false;
            over = 0;
            randi = 0;
            messagebox = false;
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
