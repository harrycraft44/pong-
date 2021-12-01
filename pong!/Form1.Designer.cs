
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
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
            this.ball.Location = new System.Drawing.Point(355, 201);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 31);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            // 
            // ed2
            // 
            this.ed2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ed2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ed2.Location = new System.Drawing.Point(-67, 0);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "escape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.ai);
            this.Controls.Add(this.P1);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox start;
    }
}

