using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//wow there no simulation in this project
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
        public bool aioo= false;
        public bool messagebox = false;
        public int[] scores = { 0, 0 };
        public int over = 0;
        public int randi = 0;
        private void playsoundf() {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(System.Reflection.Assembly.GetEntryAssembly().Location.Replace("pong!.exe","")+ "\\data\\sfx\\pong1.wav");
            player.Play();


        }
        
        private void playsoundhitwall() {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(System.Reflection.Assembly.GetEntryAssembly().Location.Replace("pong!.exe","")+ "\\data\\sfx\\pong3.wav");
            player.Play();


        }
        private void playsoundscore() {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(System.Reflection.Assembly.GetEntryAssembly().Location.Replace("pong!.exe","")+ "\\data\\sfx\\pong2.wav");
            player.Play();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            scores[0] = Properties.Settings.Default.player1;
            scores[1] = Properties.Settings.Default.ai;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            scoresupdate();


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void scoresupdate() {
            label1.Text = scores[0] + "|" + scores[1];
            Properties.Settings.Default.player1 = scores[0];
            Properties.Settings.Default.ai = scores[1];
            Properties.Settings.Default.Save();

        }
        private void aiupdate() {
            Random rnd = new Random();
            if (scores.Contains(10)) {
                
            }
            if (ball.Location.X > ai.Location.X + 20)
            {
                playsoundscore();
                scores[0] = scores[0] + 1;
                    messagebox = true;
                    restart();
                scoresupdate();
            }
            else if(ball.Location.X < P1.Location.X- 20)
            {
                playsoundscore();
                scores[1] = scores[1] + 1;
                    restart();
                scoresupdate();
            }
            if (left)
            {
                ball.Location = new Point(ball.Location.X + 5, ball.Location.Y + randi + over);
                if (ai.Bounds.IntersectsWith(ball.Bounds))
                {
                    playsoundf();
                    left = false;
                    randi = rnd.Next(-5, 5);

                }

            }
            else {
                ball.Location = new Point(ball.Location.X - 5, ball.Location.Y + randi + over);
                if (P1.Bounds.IntersectsWith(ball.Bounds))
                {
                    playsoundf();
                    left = true;
                    randi = rnd.Next(-5, 5);

                }
            }
            if (ed2.Bounds.IntersectsWith(ball.Bounds))
            {        
                playsoundhitwall();
                over = 5;
                randi = 5;
            } else if (ed.Bounds.IntersectsWith(ball.Bounds)) {
                playsoundhitwall();
                over = 5;
                randi = -5;
            }
            else {

            }
            if (ball.Location.X == ai.Location.X || ball.Location.X - 5 == ai.Location.X || ball.Location.X + 5 == ai.Location.X) { }
            else{
                if (aioo) { 
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

        }
        private void move(int add,Control a) {


            for (int i = 0; i < 20; i++)
            {
                a.Location = new Point(a.Location.X, a.Location.Y + add);
                Task.Delay(1);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down )
            {
                if (end2.Location.Y > P1.Location.Y)
                {
                    move(2,P1);
                }
            }
            else if (e.KeyCode == Keys.Up )
            {
                if (end1.Location.Y < P1.Location.Y)
                {
                    move(-2, P1);
                }

            }else if ( e.KeyCode == Keys.S)
            {
                if (end2.Location.Y > ai.Location.Y)
                {
                    move(2, ai);
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                if (end1.Location.Y < ai.Location.Y)
                {
                    move(-2, ai);
                }

            }
            else if (e.KeyCode == Keys.R) { 
                scores[1] = 0;
                scores[0] = 0; 
                restart();

            }
            else if (e.KeyCode == Keys.Escape) {
                close(); 
            } else if (e.KeyCode == Keys.A) {
                aioo = !aioo;            
            }
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

        private void close()
        {
            Properties.Settings.Default.player1 = scores[0];
            Properties.Settings.Default.ai = scores[1];
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void restart()
        {
            scoresupdate();

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

        private void fade_Tick(object sender, EventArgs e)
        {
            var r = controls.ForeColor.R - 1;
            var g = controls.ForeColor.G - 1;
            var b = controls.ForeColor.B - 1;
            if (r != 0)
            {
                controls.ForeColor = Color.FromArgb(controls.ForeColor.R - 1, controls.ForeColor.G - 1, controls.ForeColor.B - 1);
                controls.Show();
            }
            else {
                controls.Hide();
            
            }
        }

        private void controls_Click(object sender, EventArgs e)
        {

        }
    }
}
