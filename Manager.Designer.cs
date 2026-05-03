namespace Gr8Food_Management_System
{
    partial class Manager_Home
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
            this.welcome = new System.Windows.Forms.Label();
            this.Feedback_Management_Button = new System.Windows.Forms.Button();
            this.Report_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(262, 172);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(294, 37);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome Manager!";
            // 
            // Feedback_Management_Button
            // 
            this.Feedback_Management_Button.Location = new System.Drawing.Point(215, 223);
            this.Feedback_Management_Button.Name = "Feedback_Management_Button";
            this.Feedback_Management_Button.Size = new System.Drawing.Size(371, 52);
            this.Feedback_Management_Button.TabIndex = 1;
            this.Feedback_Management_Button.Text = "Feedback Management Systen";
            this.Feedback_Management_Button.UseVisualStyleBackColor = true;
            // 
            // Report_Button
            // 
            this.Report_Button.Location = new System.Drawing.Point(215, 296);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(371, 52);
            this.Report_Button.TabIndex = 2;
            this.Report_Button.Text = "E-Wallet Report";
            this.Report_Button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Profile Management ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 133);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Manager_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Report_Button);
            this.Controls.Add(this.Feedback_Management_Button);
            this.Controls.Add(this.welcome);
            this.Name = "Manager_Home";
            this.Text = "Manager_Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button Feedback_Management_Button;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}