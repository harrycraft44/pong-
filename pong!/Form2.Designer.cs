
namespace pong_
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.ai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 51F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(347, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "blong";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Location = new System.Drawing.Point(528, 72);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 31);
            this.ball.TabIndex = 7;
            this.ball.TabStop = false;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.Control;
            this.P1.Location = new System.Drawing.Point(12, 91);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(35, 110);
            this.P1.TabIndex = 5;
            this.P1.TabStop = false;
            this.P1.Click += new System.EventHandler(this.P1_Click);
            // 
            // ai
            // 
            this.ai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ai.BackColor = System.Drawing.SystemColors.Control;
            this.ai.Location = new System.Drawing.Point(875, 91);
            this.ai.Name = "ai";
            this.ai.Size = new System.Drawing.Size(35, 110);
            this.ai.TabIndex = 6;
            this.ai.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(922, 291);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.ai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox ai;
    }
}