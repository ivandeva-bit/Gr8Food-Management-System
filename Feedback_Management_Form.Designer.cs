namespace Gr8Food_Management_System
{
    partial class Feedback_Management_Form
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
            this.Feedback_details = new System.Windows.Forms.TextBox();
            this.Manager_inputtxtbox = new System.Windows.Forms.TextBox();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.respond_button = new System.Windows.Forms.Button();
            this.cusfeedentries = new System.Windows.Forms.Label();
            this.cusfeed = new System.Windows.Forms.ListBox();
            this.cussfeeddeets = new System.Windows.Forms.Label();
            this.replylbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Feedback_details
            // 
            this.Feedback_details.Location = new System.Drawing.Point(27, 63);
            this.Feedback_details.Multiline = true;
            this.Feedback_details.Name = "Feedback_details";
            this.Feedback_details.Size = new System.Drawing.Size(346, 142);
            this.Feedback_details.TabIndex = 2;
            // 
            // Manager_inputtxtbox
            // 
            this.Manager_inputtxtbox.Location = new System.Drawing.Point(27, 241);
            this.Manager_inputtxtbox.Multiline = true;
            this.Manager_inputtxtbox.Name = "Manager_inputtxtbox";
            this.Manager_inputtxtbox.Size = new System.Drawing.Size(346, 153);
            this.Manager_inputtxtbox.TabIndex = 3;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.refreshbutton.Location = new System.Drawing.Point(77, 396);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(49, 46);
            this.refreshbutton.TabIndex = 5;
            this.refreshbutton.Text = "🔄";
            this.refreshbutton.UseVisualStyleBackColor = true;
            // 
            // respond_button
            // 
            this.respond_button.Location = new System.Drawing.Point(157, 400);
            this.respond_button.Name = "respond_button";
            this.respond_button.Size = new System.Drawing.Size(159, 47);
            this.respond_button.TabIndex = 6;
            this.respond_button.Text = "Submit Reply";
            this.respond_button.UseVisualStyleBackColor = true;
            // 
            // cusfeedentries
            // 
            this.cusfeedentries.AutoSize = true;
            this.cusfeedentries.Location = new System.Drawing.Point(394, 25);
            this.cusfeedentries.Name = "cusfeedentries";
            this.cusfeedentries.Size = new System.Drawing.Size(284, 25);
            this.cusfeedentries.TabIndex = 7;
            this.cusfeedentries.Text = "Customer Feedback Entries:";
            // 
            // cusfeed
            // 
            this.cusfeed.FormattingEnabled = true;
            this.cusfeed.ItemHeight = 25;
            this.cusfeed.Location = new System.Drawing.Point(399, 63);
            this.cusfeed.Name = "cusfeed";
            this.cusfeed.Size = new System.Drawing.Size(389, 379);
            this.cusfeed.TabIndex = 9;
            // 
            // cussfeeddeets
            // 
            this.cussfeeddeets.AutoSize = true;
            this.cussfeeddeets.Location = new System.Drawing.Point(22, 25);
            this.cussfeeddeets.Name = "cussfeeddeets";
            this.cussfeeddeets.Size = new System.Drawing.Size(280, 25);
            this.cussfeeddeets.TabIndex = 10;
            this.cussfeeddeets.Text = "Customer Feedback details:";
            // 
            // replylbl
            // 
            this.replylbl.AutoSize = true;
            this.replylbl.Location = new System.Drawing.Point(22, 213);
            this.replylbl.Name = "replylbl";
            this.replylbl.Size = new System.Drawing.Size(151, 25);
            this.replylbl.TabIndex = 11;
            this.replylbl.Text = "Reply Section:";
            // 
            // Feedback_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.replylbl);
            this.Controls.Add(this.cussfeeddeets);
            this.Controls.Add(this.cusfeed);
            this.Controls.Add(this.cusfeedentries);
            this.Controls.Add(this.respond_button);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.Manager_inputtxtbox);
            this.Controls.Add(this.Feedback_details);
            this.Name = "Feedback_Management_Form";
            this.Text = "Feedback_Management_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Feedback_details;
        private System.Windows.Forms.TextBox Manager_inputtxtbox;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button respond_button;
        private System.Windows.Forms.Label cusfeedentries;
        private System.Windows.Forms.ListBox cusfeed;
        private System.Windows.Forms.Label cussfeeddeets;
        private System.Windows.Forms.Label replylbl;
    }
}