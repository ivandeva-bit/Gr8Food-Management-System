namespace Gr8Food_Management_System
{
    partial class E_Wallet_Form
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
            this.report_form_header = new System.Windows.Forms.Label();
            this.Report_data_grid = new System.Windows.Forms.DataGridView();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_filter_label = new System.Windows.Forms.Label();
            this.month_filter_label = new System.Windows.Forms.Label();
            this.customer_filter_label = new System.Windows.Forms.Label();
            this.year_filter_combobox = new System.Windows.Forms.ComboBox();
            this.month_filter_combobox = new System.Windows.Forms.ComboBox();
            this.customer_filter_comboBox = new System.Windows.Forms.ComboBox();
            this.apply_filter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Report_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // report_form_header
            // 
            this.report_form_header.AutoSize = true;
            this.report_form_header.Location = new System.Drawing.Point(402, 12);
            this.report_form_header.Name = "report_form_header";
            this.report_form_header.Size = new System.Drawing.Size(163, 25);
            this.report_form_header.TabIndex = 0;
            this.report_form_header.Text = "E-Wallet Report";
            // 
            // Report_data_grid
            // 
            this.Report_data_grid.ColumnHeadersHeight = 50;
            this.Report_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Name,
            this.Date,
            this.amount,
            this.type});
            this.Report_data_grid.Location = new System.Drawing.Point(157, 40);
            this.Report_data_grid.Name = "Report_data_grid";
            this.Report_data_grid.RowHeadersWidth = 82;
            this.Report_data_grid.RowTemplate.Height = 33;
            this.Report_data_grid.Size = new System.Drawing.Size(695, 668);
            this.Report_data_grid.TabIndex = 1;
            // 
            // Customer_Name
            // 
            this.Customer_Name.FillWeight = 140F;
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.MinimumWidth = 10;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Width = 190;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 10;
            this.amount.Name = "amount";
            // 
            // type
            // 
            this.type.HeaderText = "Type [Top-up/Usage]";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            this.type.Width = 300;
            // 
            // year_filter_label
            // 
            this.year_filter_label.AutoSize = true;
            this.year_filter_label.Location = new System.Drawing.Point(23, 477);
            this.year_filter_label.Name = "year_filter_label";
            this.year_filter_label.Size = new System.Drawing.Size(112, 25);
            this.year_filter_label.TabIndex = 13;
            this.year_filter_label.Text = "Year FIlter";
            // 
            // month_filter_label
            // 
            this.month_filter_label.AutoSize = true;
            this.month_filter_label.Location = new System.Drawing.Point(23, 276);
            this.month_filter_label.Name = "month_filter_label";
            this.month_filter_label.Size = new System.Drawing.Size(126, 25);
            this.month_filter_label.TabIndex = 12;
            this.month_filter_label.Text = "Month Filter";
            this.month_filter_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // customer_filter_label
            // 
            this.customer_filter_label.AutoSize = true;
            this.customer_filter_label.Location = new System.Drawing.Point(12, 66);
            this.customer_filter_label.Name = "customer_filter_label";
            this.customer_filter_label.Size = new System.Drawing.Size(158, 25);
            this.customer_filter_label.TabIndex = 11;
            this.customer_filter_label.Text = "Customer Filter";
            // 
            // year_filter_combobox
            // 
            this.year_filter_combobox.FormattingEnabled = true;
            this.year_filter_combobox.Location = new System.Drawing.Point(28, 505);
            this.year_filter_combobox.Name = "year_filter_combobox";
            this.year_filter_combobox.Size = new System.Drawing.Size(102, 33);
            this.year_filter_combobox.TabIndex = 10;
            // 
            // month_filter_combobox
            // 
            this.month_filter_combobox.FormattingEnabled = true;
            this.month_filter_combobox.Location = new System.Drawing.Point(28, 304);
            this.month_filter_combobox.Name = "month_filter_combobox";
            this.month_filter_combobox.Size = new System.Drawing.Size(102, 33);
            this.month_filter_combobox.TabIndex = 9;
            // 
            // customer_filter_comboBox
            // 
            this.customer_filter_comboBox.FormattingEnabled = true;
            this.customer_filter_comboBox.Location = new System.Drawing.Point(30, 94);
            this.customer_filter_comboBox.Name = "customer_filter_comboBox";
            this.customer_filter_comboBox.Size = new System.Drawing.Size(102, 33);
            this.customer_filter_comboBox.TabIndex = 8;
            // 
            // apply_filter_button
            // 
            this.apply_filter_button.Location = new System.Drawing.Point(17, 12);
            this.apply_filter_button.Name = "apply_filter_button";
            this.apply_filter_button.Size = new System.Drawing.Size(132, 33);
            this.apply_filter_button.TabIndex = 14;
            this.apply_filter_button.Text = "Apply Filter";
            this.apply_filter_button.UseVisualStyleBackColor = true;
            // 
            // E_Wallet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 720);
            this.Controls.Add(this.apply_filter_button);
            this.Controls.Add(this.year_filter_label);
            this.Controls.Add(this.month_filter_label);
            this.Controls.Add(this.customer_filter_label);
            this.Controls.Add(this.year_filter_combobox);
            this.Controls.Add(this.month_filter_combobox);
            this.Controls.Add(this.customer_filter_comboBox);
            this.Controls.Add(this.Report_data_grid);
            this.Controls.Add(this.report_form_header);
            this.Name = "E_Wallet_Form";
            this.Text = "E_Wallet_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Report_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label report_form_header;
        private System.Windows.Forms.DataGridView Report_data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Label year_filter_label;
        private System.Windows.Forms.Label month_filter_label;
        private System.Windows.Forms.Label customer_filter_label;
        private System.Windows.Forms.ComboBox year_filter_combobox;
        private System.Windows.Forms.ComboBox month_filter_combobox;
        private System.Windows.Forms.ComboBox customer_filter_comboBox;
        private System.Windows.Forms.Button apply_filter_button;
    }
}