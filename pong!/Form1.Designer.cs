
namespace pong_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.end2 = new System.Windows.Forms.PictureBox();
            this.end1 = new System.Windows.Forms.PictureBox();
            this.ai = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.ed2 = new System.Windows.Forms.PictureBox();
            this.ed = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controls = new System.Windows.Forms.Label();
            this.fade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.Control;
            this.P1.Location = new System.Drawing.Point(13, 163);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(35, 110);
            this.P1.TabIndex = 0;
            this.P1.TabStop = false;
            // 
            // end2
            // 
            this.end2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.end2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end2.Location = new System.Drawing.Point(13, 340);
            this.end2.Name = "end2";
            this.end2.Size = new System.Drawing.Size(35, 110);
            this.end2.TabIndex = 1;
            this.end2.TabStop = false;
            // 
            // end1
            // 
            this.end1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end1.Location = new System.Drawing.Point(13, 0);
            this.end1.Name = "end1";
            this.end1.Size = new System.Drawing.Size(35, 110);
            this.end1.TabIndex = 2;
            this.end1.TabStop = false;
            // 
            // ai
            // 
            this.ai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ai.BackColor = System.Drawing.SystemColors.Control;
            this.ai.Location = new System.Drawing.Point(753, 203);
            this.ai.Name = "ai";
            this.ai.Size = new System.Drawing.Size(35, 110);
            this.ai.TabIndex = 3;
            this.ai.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Location = new System.Drawing.Point(355, 203);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 31);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // ed2
            // 
            this.ed2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ed2.Location = new System.Drawing.Point(-54, 0);
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(940, 29);
            this.ed2.TabIndex = 5;
            this.ed2.TabStop = false;
            // 
            // ed
            // 
            this.ed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ed.Location = new System.Drawing.Point(-54, 421);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(940, 29);
            this.ed.TabIndex = 6;
            this.ed.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(355, 203);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(37, 29);
            this.start.TabIndex = 9;
            this.start.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 450);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Arabic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(296, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // controls
            // 
            this.controls.AutoSize = true;
            this.controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controls.ForeColor = System.Drawing.SystemColors.Control;
            this.controls.Location = new System.Drawing.Point(10, 9);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(293, 132);
            this.controls.TabIndex = 12;
            this.controls.Text = "W|up = move up\r\nS|down = move down\r\nEscape = exit\r\nR =restart\r\n";
            // 
            // fade
            // 
            this.fade.Enabled = true;
            this.fade.Interval = 20;
            this.fade.Tick += new System.EventHandler(this.fade_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.ai);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.end2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.ed2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox end2;
        private System.Windows.Forms.PictureBox end1;
        private System.Windows.Forms.PictureBox ai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox ed2;
        private System.Windows.Forms.PictureBox ed;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label controls;
        private System.Windows.Forms.Timer fade;
    }
}

