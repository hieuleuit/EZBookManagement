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
            this.bt_chart = new System.Windows.Forms.Button();
            this.bt_nv = new System.Windows.Forms.Button();
            this.bt_luong = new System.Windows.Forms.Button();
            this.bt_csvc = new System.Windows.Forms.Button();
            this.bt_ql = new System.Windows.Forms.Button();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_addnv = new System.Windows.Forms.Button();
            this.bt_delnv = new System.Windows.Forms.Button();
            this.bt_editnv = new System.Windows.Forms.Button();
            this.bt_savenv = new System.Windows.Forms.Button();
            this.dgv_st = new System.Windows.Forms.DataGridView();
            this.pn_nv = new System.Windows.Forms.Panel();
            this.pn_add_save = new System.Windows.Forms.Panel();
            this.pn_edit_save = new System.Windows.Forms.Panel();
            this.bt_esave = new System.Windows.Forms.Button();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.cbb_sl = new System.Windows.Forms.ComboBox();
            this.cbb_dob = new System.Windows.Forms.ComboBox();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.cbb_name = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_bl = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_export_to_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_st)).BeginInit();
            this.pn_nv.SuspendLayout();
            this.pn_add_save.SuspendLayout();
            this.pn_edit_save.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // bt_ql
            // 
            this.bt_ql.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.nv_ql;
            this.bt_ql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ql.FlatAppearance.BorderSize = 0;
            this.bt_ql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ql.Location = new System.Drawing.Point(805, 7);
            this.bt_ql.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ql.Name = "bt_ql";
            this.bt_ql.Size = new System.Drawing.Size(102, 102);
            this.bt_ql.TabIndex = 4;
            this.bt_ql.UseVisualStyleBackColor = true;
            // 
            // bt_tk
            // 
            this.bt_tk.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.nv_tk;
            this.bt_tk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_tk.FlatAppearance.BorderSize = 0;
            this.bt_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tk.Location = new System.Drawing.Point(922, 6);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(102, 102);
            this.bt_tk.TabIndex = 5;
            this.bt_tk.UseVisualStyleBackColor = true;
            // 
            // bt_addnv
            // 
            this.bt_addnv.Location = new System.Drawing.Point(0, 2);
            this.bt_addnv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_addnv.Name = "bt_addnv";
            this.bt_addnv.Size = new System.Drawing.Size(62, 30);
            this.bt_addnv.TabIndex = 7;
            this.bt_addnv.Text = "Thêm";
            this.bt_addnv.UseVisualStyleBackColor = true;
            this.bt_addnv.Click += new System.EventHandler(this.bt_addnv_Click);
            // 
            // bt_delnv
            // 
            this.bt_delnv.Location = new System.Drawing.Point(552, 217);
            this.bt_delnv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_delnv.Name = "bt_delnv";
            this.bt_delnv.Size = new System.Drawing.Size(62, 30);
            this.bt_delnv.TabIndex = 8;
            this.bt_delnv.Text = "Xóa";
            this.bt_delnv.UseVisualStyleBackColor = true;
            this.bt_delnv.Click += new System.EventHandler(this.bt_delnv_Click);
            // 
            // bt_editnv
            // 
            this.bt_editnv.Location = new System.Drawing.Point(2, 2);
            this.bt_editnv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_editnv.Name = "bt_editnv";
            this.bt_editnv.Size = new System.Drawing.Size(62, 30);
            this.bt_editnv.TabIndex = 9;
            this.bt_editnv.Text = "Sửa";
            this.bt_editnv.UseVisualStyleBackColor = true;
            this.bt_editnv.Click += new System.EventHandler(this.bt_editnv_Click);
            // 
            // bt_savenv
            // 
            this.bt_savenv.Location = new System.Drawing.Point(2, 53);
            this.bt_savenv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_savenv.Name = "bt_savenv";
            this.bt_savenv.Size = new System.Drawing.Size(62, 30);
            this.bt_savenv.TabIndex = 10;
            this.bt_savenv.Text = "Lưu";
            this.bt_savenv.UseVisualStyleBackColor = true;
            this.bt_savenv.Click += new System.EventHandler(this.bt_savenv_Click);
            // 
            // dgv_st
            // 
            this.dgv_st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_st.Location = new System.Drawing.Point(4, 348);
            this.dgv_st.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_st.Name = "dgv_st";
            this.dgv_st.RowTemplate.Height = 24;
            this.dgv_st.Size = new System.Drawing.Size(839, 221);
            this.dgv_st.TabIndex = 11;
            this.dgv_st.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_st_CellClick);
            this.dgv_st.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_st_RowEnter);
            // 
            // pn_nv
            // 
            this.pn_nv.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.pn_nvreallast;
            this.pn_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_nv.Controls.Add(this.pn_add_save);
            this.pn_nv.Controls.Add(this.pn_edit_save);
            this.pn_nv.Controls.Add(this.bt_delnv);
            this.pn_nv.Controls.Add(this.rb_female);
            this.pn_nv.Controls.Add(this.rb_male);
            this.pn_nv.Controls.Add(this.cbb_role);
            this.pn_nv.Controls.Add(this.cbb_sl);
            this.pn_nv.Controls.Add(this.cbb_dob);
            this.pn_nv.Controls.Add(this.cbb_id);
            this.pn_nv.Controls.Add(this.cbb_name);
            this.pn_nv.Controls.Add(this.dtp);
            this.pn_nv.Controls.Add(this.tb_role);
            this.pn_nv.Controls.Add(this.tb_bl);
            this.pn_nv.Controls.Add(this.tb_phone);
            this.pn_nv.Controls.Add(this.tb_id);
            this.pn_nv.Controls.Add(this.tb_name);
            this.pn_nv.Controls.Add(this.dgv_st);
            this.pn_nv.Location = new System.Drawing.Point(186, 116);
            this.pn_nv.Margin = new System.Windows.Forms.Padding(2);
            this.pn_nv.Name = "pn_nv";
            this.pn_nv.Size = new System.Drawing.Size(850, 577);
            this.pn_nv.TabIndex = 12;
            // 
            // pn_add_save
            // 
            this.pn_add_save.Controls.Add(this.bt_addnv);
            this.pn_add_save.Controls.Add(this.bt_savenv);
            this.pn_add_save.Location = new System.Drawing.Point(473, 217);
            this.pn_add_save.Name = "pn_add_save";
            this.pn_add_save.Size = new System.Drawing.Size(63, 83);
            this.pn_add_save.TabIndex = 30;
            // 
            // pn_edit_save
            // 
            this.pn_edit_save.Controls.Add(this.bt_editnv);
            this.pn_edit_save.Controls.Add(this.bt_esave);
            this.pn_edit_save.Location = new System.Drawing.Point(630, 217);
            this.pn_edit_save.Name = "pn_edit_save";
            this.pn_edit_save.Size = new System.Drawing.Size(65, 85);
            this.pn_edit_save.TabIndex = 29;
            // 
            // bt_esave
            // 
            this.bt_esave.Location = new System.Drawing.Point(2, 55);
            this.bt_esave.Margin = new System.Windows.Forms.Padding(2);
            this.bt_esave.Name = "bt_esave";
            this.bt_esave.Size = new System.Drawing.Size(62, 30);
            this.bt_esave.TabIndex = 28;
            this.bt_esave.Text = "Lưu";
            this.bt_esave.UseVisualStyleBackColor = true;
            this.bt_esave.Click += new System.EventHandler(this.bt_esave_Click);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.BackColor = System.Drawing.Color.Transparent;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(226, 240);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(51, 27);
            this.rb_female.TabIndex = 26;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Nữ";
            this.rb_female.UseVisualStyleBackColor = false;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.BackColor = System.Drawing.Color.Transparent;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(126, 240);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(68, 27);
            this.rb_male.TabIndex = 25;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Nam";
            this.rb_male.UseVisualStyleBackColor = false;
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Items.AddRange(new object[] {
            "Cao-Thấp",
            "Thấp-Cao"});
            this.cbb_role.Location = new System.Drawing.Point(714, 314);
            this.cbb_role.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(65, 21);
            this.cbb_role.TabIndex = 24;
            // 
            // cbb_sl
            // 
            this.cbb_sl.FormattingEnabled = true;
            this.cbb_sl.Items.AddRange(new object[] {
            "Tăng",
            "Giảm"});
            this.cbb_sl.Location = new System.Drawing.Point(578, 314);
            this.cbb_sl.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_sl.Name = "cbb_sl";
            this.cbb_sl.Size = new System.Drawing.Size(65, 21);
            this.cbb_sl.TabIndex = 23;
            // 
            // cbb_dob
            // 
            this.cbb_dob.FormattingEnabled = true;
            this.cbb_dob.Items.AddRange(new object[] {
            "Tăng",
            "Giảm"});
            this.cbb_dob.Location = new System.Drawing.Point(424, 314);
            this.cbb_dob.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_dob.Name = "cbb_dob";
            this.cbb_dob.Size = new System.Drawing.Size(65, 21);
            this.cbb_dob.TabIndex = 22;
            // 
            // cbb_id
            // 
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Items.AddRange(new object[] {
            "Tăng",
            "Giảm"});
            this.cbb_id.Location = new System.Drawing.Point(273, 314);
            this.cbb_id.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(65, 21);
            this.cbb_id.TabIndex = 21;
            // 
            // cbb_name
            // 
            this.cbb_name.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.cbb_name.Location = new System.Drawing.Point(160, 314);
            this.cbb_name.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_name.Name = "cbb_name";
            this.cbb_name.Size = new System.Drawing.Size(53, 21);
            this.cbb_name.TabIndex = 20;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtp.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(126, 196);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(187, 20);
            this.dtp.TabIndex = 19;
            this.dtp.Value = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            // 
            // tb_role
            // 
            this.tb_role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_role.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_role.Location = new System.Drawing.Point(473, 188);
            this.tb_role.Margin = new System.Windows.Forms.Padding(2);
            this.tb_role.Multiline = true;
            this.tb_role.Name = "tb_role";
            this.tb_role.Size = new System.Drawing.Size(206, 21);
            this.tb_role.TabIndex = 16;
            // 
            // tb_bl
            // 
            this.tb_bl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_bl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bl.Location = new System.Drawing.Point(473, 137);
            this.tb_bl.Margin = new System.Windows.Forms.Padding(2);
            this.tb_bl.Multiline = true;
            this.tb_bl.Name = "tb_bl";
            this.tb_bl.Size = new System.Drawing.Size(206, 21);
            this.tb_bl.TabIndex = 15;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(473, 85);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(206, 21);
            this.tb_phone.TabIndex = 14;
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(106, 137);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(206, 21);
            this.tb_id.TabIndex = 13;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(106, 85);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 21);
            this.tb_name.TabIndex = 12;
            // 
            // bt_export_to_excel
            // 
            this.bt_export_to_excel.Location = new System.Drawing.Point(386, 46);
            this.bt_export_to_excel.Name = "bt_export_to_excel";
            this.bt_export_to_excel.Size = new System.Drawing.Size(262, 23);
            this.bt_export_to_excel.TabIndex = 13;
            this.bt_export_to_excel.Text = "EXPORT TO EXCEL";
            this.bt_export_to_excel.UseVisualStyleBackColor = true;
            this.bt_export_to_excel.Click += new System.EventHandler(this.bt_export_to_excel_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Biggest_laststt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 693);
            this.Controls.Add(this.bt_export_to_excel);
            this.Controls.Add(this.pn_nv);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_st)).EndInit();
            this.pn_nv.ResumeLayout(false);
            this.pn_nv.PerformLayout();
            this.pn_add_save.ResumeLayout(false);
            this.pn_edit_save.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_chart;
        private System.Windows.Forms.Button bt_nv;
        private System.Windows.Forms.Button bt_luong;
        private System.Windows.Forms.Button bt_csvc;
        private System.Windows.Forms.Button bt_ql;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Button bt_addnv;
        private System.Windows.Forms.Button bt_delnv;
        private System.Windows.Forms.Button bt_editnv;
        private System.Windows.Forms.Button bt_savenv;
        private System.Windows.Forms.DataGridView dgv_st;
        private System.Windows.Forms.Panel pn_nv;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.TextBox tb_bl;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.ComboBox cbb_sl;
        private System.Windows.Forms.ComboBox cbb_dob;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.ComboBox cbb_name;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Button bt_esave;
        private System.Windows.Forms.Panel pn_add_save;
        private System.Windows.Forms.Panel pn_edit_save;
        private System.Windows.Forms.Button bt_export_to_excel;
    }
}