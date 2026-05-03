namespace Gr8Food_Management_System
{
    partial class Manager_Profile_Management_Form
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
            this.profile_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update_profile_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // profile_label
            // 
            this.profile_label.AutoSize = true;
            this.profile_label.Location = new System.Drawing.Point(263, 21);
            this.profile_label.Name = "profile_label";
            this.profile_label.Size = new System.Drawing.Size(336, 25);
            this.profile_label.TabIndex = 0;
            this.profile_label.Text = "Welcome To Profile Management!";
            // 
            // name_textbox
            // 
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_textbox.Location = new System.Drawing.Point(381, 179);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(385, 31);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.Text = "Input your new name";
            this.name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email_textbox
            // 
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_textbox.Location = new System.Drawing.Point(381, 234);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(385, 31);
            this.email_textbox.TabIndex = 2;
            this.email_textbox.Text = "Input your new email";
            this.email_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 249);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // update_profile_button
            // 
            this.update_profile_button.Location = new System.Drawing.Point(120, 353);
            this.update_profile_button.Name = "update_profile_button";
            this.update_profile_button.Size = new System.Drawing.Size(163, 86);
            this.update_profile_button.TabIndex = 5;
            this.update_profile_button.Text = "Upload New Profile Picture";
            this.update_profile_button.UseVisualStyleBackColor = true;
            // 
            // Manager_Profile_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_profile_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.profile_label);
            this.Name = "Manager_Profile_Management_Form";
            this.Text = "Manager_Profile_Management_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profile_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update_profile_button;
    }
}