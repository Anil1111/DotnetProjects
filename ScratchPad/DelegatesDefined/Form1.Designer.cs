namespace DelegatesDefined
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
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdAccountNumber = new System.Windows.Forms.RadioButton();
            this.rdBalance = new System.Windows.Forms.RadioButton();
            this.rdSortByAddress = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(34, 11);
            this.rdName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(53, 17);
            this.rdName.TabIndex = 0;
            this.rdName.TabStop = true;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.Click += new System.EventHandler(this.SortByRadioButton_Click);
            // 
            // rdAccountNumber
            // 
            this.rdAccountNumber.AutoSize = true;
            this.rdAccountNumber.Location = new System.Drawing.Point(143, 10);
            this.rdAccountNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdAccountNumber.Name = "rdAccountNumber";
            this.rdAccountNumber.Size = new System.Drawing.Size(105, 17);
            this.rdAccountNumber.TabIndex = 1;
            this.rdAccountNumber.TabStop = true;
            this.rdAccountNumber.Text = "Account Number";
            this.rdAccountNumber.UseVisualStyleBackColor = true;
            this.rdAccountNumber.Click += new System.EventHandler(this.SortByRadioButton_Click);
            // 
            // rdBalance
            // 
            this.rdBalance.AutoSize = true;
            this.rdBalance.Location = new System.Drawing.Point(284, 11);
            this.rdBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdBalance.Name = "rdBalance";
            this.rdBalance.Size = new System.Drawing.Size(64, 17);
            this.rdBalance.TabIndex = 2;
            this.rdBalance.TabStop = true;
            this.rdBalance.Text = "Balance";
            this.rdBalance.UseVisualStyleBackColor = true;
            this.rdBalance.Click += new System.EventHandler(this.SortByRadioButton_Click);
            // 
            // rdSortByAddress
            // 
            this.rdSortByAddress.AutoSize = true;
            this.rdSortByAddress.Location = new System.Drawing.Point(34, 65);
            this.rdSortByAddress.Name = "rdSortByAddress";
            this.rdSortByAddress.Size = new System.Drawing.Size(100, 17);
            this.rdSortByAddress.TabIndex = 3;
            this.rdSortByAddress.TabStop = true;
            this.rdSortByAddress.Text = "Sort By Address";
            this.rdSortByAddress.UseVisualStyleBackColor = true;
            this.rdSortByAddress.Click += new System.EventHandler(this.SortByAddressesRadioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 124);
            this.Controls.Add(this.rdSortByAddress);
            this.Controls.Add(this.rdBalance);
            this.Controls.Add(this.rdAccountNumber);
            this.Controls.Add(this.rdName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdAccountNumber;
        private System.Windows.Forms.RadioButton rdBalance;
        private System.Windows.Forms.RadioButton rdSortByAddress;
    }
}

