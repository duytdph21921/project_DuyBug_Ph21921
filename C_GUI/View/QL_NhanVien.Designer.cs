namespace DuAn1_Winform
{
    partial class QL_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NhanVien));
            this.dtg_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_timkiemtheotennv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdb_nhanviendanglamviec = new System.Windows.Forms.RadioButton();
            this.rdb_nhanviennghiviec = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_anh = new System.Windows.Forms.ComboBox();
            this.ptb_anh = new System.Windows.Forms.PictureBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_nghiviec = new System.Windows.Forms.CheckBox();
            this.cb_danglamviec = new System.Windows.Forms.CheckBox();
            this.cb_nu = new System.Windows.Forms.CheckBox();
            this.cb_nam = new System.Windows.Forms.CheckBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_hovaten = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_nhanvien
            // 
            this.dtg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nhanvien.Location = new System.Drawing.Point(9, 135);
            this.dtg_nhanvien.Name = "dtg_nhanvien";
            this.dtg_nhanvien.RowHeadersWidth = 51;
            this.dtg_nhanvien.RowTemplate.Height = 29;
            this.dtg_nhanvien.Size = new System.Drawing.Size(868, 709);
            this.dtg_nhanvien.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_them.IconColor = System.Drawing.Color.Black;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(914, 688);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.btn_them.Size = new System.Drawing.Size(176, 53);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "THÊM";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(1358, 688);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.btn_sua.Size = new System.Drawing.Size(176, 53);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_xoa.IconColor = System.Drawing.Color.Black;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(1147, 688);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(176, 53);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Trạng Thái:";
            // 
            // tb_timkiemtheotennv
            // 
            this.tb_timkiemtheotennv.Location = new System.Drawing.Point(98, 102);
            this.tb_timkiemtheotennv.Name = "tb_timkiemtheotennv";
            this.tb_timkiemtheotennv.PlaceholderText = "Nhập tên Nhân Viên cần tìm kiếm ...";
            this.tb_timkiemtheotennv.Size = new System.Drawing.Size(399, 27);
            this.tb_timkiemtheotennv.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tìm kiếm:";
            // 
            // rdb_nhanviendanglamviec
            // 
            this.rdb_nhanviendanglamviec.AutoSize = true;
            this.rdb_nhanviendanglamviec.Location = new System.Drawing.Point(98, 49);
            this.rdb_nhanviendanglamviec.Name = "rdb_nhanviendanglamviec";
            this.rdb_nhanviendanglamviec.Size = new System.Drawing.Size(193, 24);
            this.rdb_nhanviendanglamviec.TabIndex = 16;
            this.rdb_nhanviendanglamviec.TabStop = true;
            this.rdb_nhanviendanglamviec.Text = "Nhân viên đang làm việc";
            this.rdb_nhanviendanglamviec.UseVisualStyleBackColor = true;
            // 
            // rdb_nhanviennghiviec
            // 
            this.rdb_nhanviennghiviec.AutoSize = true;
            this.rdb_nhanviennghiviec.Location = new System.Drawing.Point(363, 49);
            this.rdb_nhanviennghiviec.Name = "rdb_nhanviennghiviec";
            this.rdb_nhanviennghiviec.Size = new System.Drawing.Size(180, 24);
            this.rdb_nhanviennghiviec.TabIndex = 17;
            this.rdb_nhanviennghiviec.TabStop = true;
            this.rdb_nhanviennghiviec.Text = "Nhân viên đã nghỉ việc";
            this.rdb_nhanviennghiviec.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_nhanviennghiviec);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rdb_nhanviendanglamviec);
            this.groupBox1.Controls.Add(this.tb_timkiemtheotennv);
            this.groupBox1.Controls.Add(this.dtg_nhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 850);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_anh);
            this.groupBox2.Controls.Add(this.ptb_anh);
            this.groupBox2.Controls.Add(this.cbb_chucvu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_nghiviec);
            this.groupBox2.Controls.Add(this.cb_danglamviec);
            this.groupBox2.Controls.Add(this.cb_nu);
            this.groupBox2.Controls.Add(this.cb_nam);
            this.groupBox2.Controls.Add(this.tb_diachi);
            this.groupBox2.Controls.Add(this.tb_sdt);
            this.groupBox2.Controls.Add(this.tb_matkhau);
            this.groupBox2.Controls.Add(this.tb_hovaten);
            this.groupBox2.Controls.Add(this.dtp_ngaysinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_manv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(914, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 611);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cbb_anh
            // 
            this.cbb_anh.FormattingEnabled = true;
            this.cbb_anh.Location = new System.Drawing.Point(53, 264);
            this.cbb_anh.Name = "cbb_anh";
            this.cbb_anh.Size = new System.Drawing.Size(200, 28);
            this.cbb_anh.TabIndex = 35;
            // 
            // ptb_anh
            // 
            this.ptb_anh.Image = ((System.Drawing.Image)(resources.GetObject("ptb_anh.Image")));
            this.ptb_anh.Location = new System.Drawing.Point(53, 49);
            this.ptb_anh.Name = "ptb_anh";
            this.ptb_anh.Size = new System.Drawing.Size(200, 209);
            this.ptb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_anh.TabIndex = 34;
            this.ptb_anh.TabStop = false;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(279, 459);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(289, 28);
            this.cbb_chucvu.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Chức Vụ";
            // 
            // cb_nghiviec
            // 
            this.cb_nghiviec.AutoSize = true;
            this.cb_nghiviec.Location = new System.Drawing.Point(55, 503);
            this.cb_nghiviec.Name = "cb_nghiviec";
            this.cb_nghiviec.Size = new System.Drawing.Size(93, 24);
            this.cb_nghiviec.TabIndex = 31;
            this.cb_nghiviec.Text = "Nghỉ việc";
            this.cb_nghiviec.UseVisualStyleBackColor = true;
            // 
            // cb_danglamviec
            // 
            this.cb_danglamviec.AutoSize = true;
            this.cb_danglamviec.Location = new System.Drawing.Point(55, 463);
            this.cb_danglamviec.Name = "cb_danglamviec";
            this.cb_danglamviec.Size = new System.Drawing.Size(126, 24);
            this.cb_danglamviec.TabIndex = 30;
            this.cb_danglamviec.Text = "Đang làm việc";
            this.cb_danglamviec.UseVisualStyleBackColor = true;
            // 
            // cb_nu
            // 
            this.cb_nu.AutoSize = true;
            this.cb_nu.Location = new System.Drawing.Point(55, 384);
            this.cb_nu.Name = "cb_nu";
            this.cb_nu.Size = new System.Drawing.Size(51, 24);
            this.cb_nu.TabIndex = 29;
            this.cb_nu.Text = "Nữ";
            this.cb_nu.UseVisualStyleBackColor = true;
            // 
            // cb_nam
            // 
            this.cb_nam.AutoSize = true;
            this.cb_nam.Location = new System.Drawing.Point(55, 353);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(63, 24);
            this.cb_nam.TabIndex = 28;
            this.cb_nam.Text = "Nam";
            this.cb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(279, 306);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(289, 27);
            this.tb_diachi.TabIndex = 27;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(279, 384);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(289, 27);
            this.tb_sdt.TabIndex = 26;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(280, 540);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(289, 27);
            this.tb_matkhau.TabIndex = 25;
            // 
            // tb_hovaten
            // 
            this.tb_hovaten.Location = new System.Drawing.Point(279, 155);
            this.tb_hovaten.Name = "tb_hovaten";
            this.tb_hovaten.Size = new System.Drawing.Size(289, 27);
            this.tb_hovaten.TabIndex = 24;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(279, 230);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(289, 27);
            this.dtp_ngaysinh.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giới Tính";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(279, 80);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(289, 27);
            this.tb_manv.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và Tên";
            // 
            // QL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 874);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_them);
            this.Name = "QL_NhanVien";
            this.Text = "QL_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_nhanvien;
        private FontAwesome.Sharp.IconButton btn_them;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_timkiemtheotennv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdb_nhanviendanglamviec;
        private System.Windows.Forms.RadioButton rdb_nhanviennghiviec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_nghiviec;
        private System.Windows.Forms.CheckBox cb_danglamviec;
        private System.Windows.Forms.CheckBox cb_nu;
        private System.Windows.Forms.CheckBox cb_nam;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_hovaten;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptb_anh;
        private System.Windows.Forms.ComboBox cbb_anh;
    }
}