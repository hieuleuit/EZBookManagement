namespace BookstoreManagementApp_Final_
{
    partial class EmployeeSaleForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageButton
            // 
            this.ManageButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Manage_i;
            this.ManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageButton.Location = new System.Drawing.Point(19, 112);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(88, 76);
            this.ManageButton.TabIndex = 19;
            this.ManageButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Lookup;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Location = new System.Drawing.Point(19, 297);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 76);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Chart;
            this.ReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportButton.Location = new System.Drawing.Point(19, 388);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(88, 76);
            this.ReportButton.TabIndex = 17;
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // SaleButton
            // 
            this.SaleButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.shopping_i;
            this.SaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaleButton.Location = new System.Drawing.Point(19, 206);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(88, 76);
            this.SaleButton.TabIndex = 16;
            this.SaleButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Customers;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(700, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 76);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.BILL;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(594, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 76);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.SaleButton);
            this.Name = "EmployeeSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSaleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}