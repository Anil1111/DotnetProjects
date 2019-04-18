namespace EmployeeProcessing
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
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.giveRaiseBtn = new System.Windows.Forms.Button();
            this.shoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(12, 12);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(608, 212);
            this.employeeListBox.TabIndex = 0;
            // 
            // giveRaiseBtn
            // 
            this.giveRaiseBtn.Location = new System.Drawing.Point(12, 244);
            this.giveRaiseBtn.Name = "giveRaiseBtn";
            this.giveRaiseBtn.Size = new System.Drawing.Size(141, 35);
            this.giveRaiseBtn.TabIndex = 1;
            this.giveRaiseBtn.Text = "Give Raise";
            this.giveRaiseBtn.UseVisualStyleBackColor = true;
            this.giveRaiseBtn.Click += new System.EventHandler(this.GiveRaiseBtn_Click);
            // 
            // shoutBtn
            // 
            this.shoutBtn.Location = new System.Drawing.Point(231, 244);
            this.shoutBtn.Name = "shoutBtn";
            this.shoutBtn.Size = new System.Drawing.Size(141, 35);
            this.shoutBtn.TabIndex = 2;
            this.shoutBtn.Text = "Shout";
            this.shoutBtn.UseVisualStyleBackColor = true;
            this.shoutBtn.Click += new System.EventHandler(this.ShoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 291);
            this.Controls.Add(this.shoutBtn);
            this.Controls.Add(this.giveRaiseBtn);
            this.Controls.Add(this.employeeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button giveRaiseBtn;
        private System.Windows.Forms.Button shoutBtn;
    }
}

