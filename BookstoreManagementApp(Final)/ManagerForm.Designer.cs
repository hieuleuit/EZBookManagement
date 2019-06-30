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
            this.lb_slr_id = new System.Windows.Forms.Label();
            this.lb_slr_us = new System.Windows.Forms.Label();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_ql = new System.Windows.Forms.Button();
            this.bt_csvc = new System.Windows.Forms.Button();
            this.bt_luong = new System.Windows.Forms.Button();
            this.bt_nv = new System.Windows.Forms.Button();
            this.bt_chart = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_slr_id
            // 
            this.lb_slr_id.AutoSize = true;
            this.lb_slr_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_slr_id.Location = new System.Drawing.Point(14, 622);
            this.lb_slr_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_slr_id.Name = "lb_slr_id";
            this.lb_slr_id.Size = new System.Drawing.Size(60, 15);
            this.lb_slr_id.TabIndex = 17;
            this.lb_slr_id.Text = "                 ";
            // 
            // lb_slr_us
            // 
            this.lb_slr_us.AutoSize = true;
            this.lb_slr_us.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_slr_us.Location = new System.Drawing.Point(14, 647);
            this.lb_slr_us.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_slr_us.Name = "lb_slr_us";
            this.lb_slr_us.Size = new System.Drawing.Size(60, 15);
            this.lb_slr_us.TabIndex = 18;
            this.lb_slr_us.Text = "                 ";
            // 
            // bt_tk
            // 
            this.bt_tk.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.nv_tk;
            this.bt_tk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_tk.FlatAppearance.BorderSize = 0;
            this.bt_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tk.Location = new System.Drawing.Point(1066, 10);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(102, 102);
            this.bt_tk.TabIndex = 5;
            this.bt_tk.UseVisualStyleBackColor = true;
            // 
            // bt_ql
            // 
            this.bt_ql.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.nv_ql;
            this.bt_ql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ql.FlatAppearance.BorderSize = 0;
            this.bt_ql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ql.Location = new System.Drawing.Point(949, 11);
            this.bt_ql.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ql.Name = "bt_ql";
            this.bt_ql.Size = new System.Drawing.Size(102, 102);
            this.bt_ql.TabIndex = 4;
            this.bt_ql.UseVisualStyleBackColor = true;
            // 
            // bt_csvc
            // 
            this.bt_csvc.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.CSVC;
            this.bt_csvc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_csvc.FlatAppearance.BorderSize = 0;
            this.bt_csvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_csvc.Location = new System.Drawing.Point(19, 357);
            this.bt_csvc.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc.Name = "bt_csvc";
            this.bt_csvc.Size = new System.Drawing.Size(150, 41);
            this.bt_csvc.TabIndex = 3;
            this.bt_csvc.UseVisualStyleBackColor = true;
            this.bt_csvc.Click += new System.EventHandler(this.bt_csvc_Click);
            // 
            // bt_luong
            // 
            this.bt_luong.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Slr;
            this.bt_luong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_luong.FlatAppearance.BorderSize = 0;
            this.bt_luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_luong.Location = new System.Drawing.Point(19, 301);
            this.bt_luong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luong.Name = "bt_luong";
            this.bt_luong.Size = new System.Drawing.Size(150, 41);
            this.bt_luong.TabIndex = 2;
            this.bt_luong.UseVisualStyleBackColor = true;
            this.bt_luong.Click += new System.EventHandler(this.bt_luong_Click);
            // 
            // bt_nv
            // 
            this.bt_nv.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.nv;
            this.bt_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nv.FlatAppearance.BorderSize = 0;
            this.bt_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nv.Location = new System.Drawing.Point(19, 245);
            this.bt_nv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_nv.Name = "bt_nv";
            this.bt_nv.Size = new System.Drawing.Size(150, 41);
            this.bt_nv.TabIndex = 1;
            this.bt_nv.UseVisualStyleBackColor = true;
            this.bt_nv.Click += new System.EventHandler(this.bt_nv_Click);
            // 
            // bt_chart
            // 
            this.bt_chart.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Chart1;
            this.bt_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_chart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt_chart.FlatAppearance.BorderSize = 0;
            this.bt_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chart.Location = new System.Drawing.Point(19, 188);
            this.bt_chart.Margin = new System.Windows.Forms.Padding(2);
            this.bt_chart.Name = "bt_chart";
            this.bt_chart.Size = new System.Drawing.Size(150, 41);
            this.bt_chart.TabIndex = 0;
            this.bt_chart.UseVisualStyleBackColor = true;
            this.bt_chart.Click += new System.EventHandler(this.bt_chart_Click);
            // 
            // pn_main
            // 
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_main.Location = new System.Drawing.Point(186, 116);
            this.pn_main.Margin = new System.Windows.Forms.Padding(2);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(985, 655);
            this.pn_main.TabIndex = 12;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 773);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.lb_slr_us);
            this.Controls.Add(this.lb_slr_id);
            this.Controls.Add(this.bt_tk);
            this.Controls.Add(this.bt_ql);
            this.Controls.Add(this.bt_csvc);
            this.Controls.Add(this.bt_luong);
            this.Controls.Add(this.bt_nv);
            this.Controls.Add(this.bt_chart);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_chart;
        private System.Windows.Forms.Button bt_nv;
        private System.Windows.Forms.Button bt_luong;
        private System.Windows.Forms.Button bt_csvc;
        private System.Windows.Forms.Button bt_ql;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Label lb_slr_id;
        private System.Windows.Forms.Label lb_slr_us;
        private System.Windows.Forms.Panel pn_main;
    }
}