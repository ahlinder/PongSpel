namespace Pong
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
            this.spelplan = new System.Windows.Forms.Panel();
            this.rack = new System.Windows.Forms.PictureBox();
            this.boll = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spelplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            this.SuspendLayout();
            // 
            // spelplan
            // 
            this.spelplan.Controls.Add(this.rack);
            this.spelplan.Controls.Add(this.boll);
            this.spelplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spelplan.Location = new System.Drawing.Point(0, 0);
            this.spelplan.Name = "spelplan";
            this.spelplan.Size = new System.Drawing.Size(402, 338);
            this.spelplan.TabIndex = 0;
            // 
            // rack
            // 
            this.rack.BackColor = System.Drawing.Color.Red;
            this.rack.Location = new System.Drawing.Point(144, 276);
            this.rack.Name = "rack";
            this.rack.Size = new System.Drawing.Size(140, 20);
            this.rack.TabIndex = 1;
            this.rack.TabStop = false;
            // 
            // boll
            // 
            this.boll.BackColor = System.Drawing.Color.Blue;
            this.boll.Location = new System.Drawing.Point(215, 142);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(25, 25);
            this.boll.TabIndex = 0;
            this.boll.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 338);
            this.Controls.Add(this.spelplan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.spelplan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel spelplan;
        private System.Windows.Forms.PictureBox rack;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.Timer timer1;
    }
}

