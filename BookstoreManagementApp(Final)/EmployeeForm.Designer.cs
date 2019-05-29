namespace BookstoreManagementApp_Final_
{
    partial class EmployeeForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Lookup;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Location = new System.Drawing.Point(12, 297);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 76);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ManageButton
            // 
            this.ManageButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Manage_i;
            this.ManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageButton.Location = new System.Drawing.Point(12, 106);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(88, 76);
            this.ManageButton.TabIndex = 8;
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Chart;
            this.ReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportButton.Location = new System.Drawing.Point(12, 390);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(88, 76);
            this.ReportButton.TabIndex = 7;
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // SaleButton
            // 
            this.SaleButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.shopping_i;
            this.SaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaleButton.Location = new System.Drawing.Point(12, 202);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(88, 76);
            this.SaleButton.TabIndex = 6;
            this.SaleButton.UseVisualStyleBackColor = true;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Logout;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.Location = new System.Drawing.Point(697, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(91, 33);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.SaleButton);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}