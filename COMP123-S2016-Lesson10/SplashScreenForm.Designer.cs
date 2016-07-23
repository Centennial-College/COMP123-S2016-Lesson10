namespace COMP123_S2016_Lesson10
{
    partial class SplashScreenForm
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
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashScreenLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 5000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreenLabel
            // 
            this.SplashScreenLabel.AutoSize = true;
            this.SplashScreenLabel.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenLabel.Location = new System.Drawing.Point(165, 38);
            this.SplashScreenLabel.Name = "SplashScreenLabel";
            this.SplashScreenLabel.Size = new System.Drawing.Size(310, 31);
            this.SplashScreenLabel.TabIndex = 0;
            this.SplashScreenLabel.Text = "Welcome To my App!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2016_Lesson10.Properties.Resources.pokemon_go;
            this.pictureBox1.Location = new System.Drawing.Point(171, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SplashScreenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashScreenTimer;
        private System.Windows.Forms.Label SplashScreenLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}