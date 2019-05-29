namespace BookstoreManagementApp_Final_
{
    partial class ManagerForm
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
            this.ManageButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageButton
            // 
            this.ManageButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.STAFF;
            this.ManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageButton.Location = new System.Drawing.Point(14, 156);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(88, 76);
            this.ManageButton.TabIndex = 8;
            this.ManageButton.UseVisualStyleBackColor = true;
            // 
            // SaleButton
            // 
            this.SaleButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Store_manage;
            this.SaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaleButton.Location = new System.Drawing.Point(14, 252);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(88, 76);
            this.SaleButton.TabIndex = 6;
            this.SaleButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Logout;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutButton.Location = new System.Drawing.Point(697, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(91, 33);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Manager_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.SaleButton);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}