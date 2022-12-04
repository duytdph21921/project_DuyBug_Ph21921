namespace DuAn1_Winform
{
    partial class QL_KhuyenMai
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_khuyenmai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiemKM = new FontAwesome.Sharp.IconButton();
            this.dtp_ngayketthuctimkiem = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaybatdautimkiem = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_timkiemKM = new System.Windows.Forms.TextBox();
            this.rdb_hethan = new System.Windows.Forms.RadioButton();
            this.rdb_conhan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_tenCTkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mucgiam = new System.Windows.Forms.TextBox();
            this.tb_makm = new System.Windows.Forms.TextBox();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_khuyenmai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tìm kiếm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Trạng Thái:";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_them.IconColor = System.Drawing.Color.Black;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(991, 482);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.btn_them.Size = new System.Drawing.Size(176, 53);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "THÊM";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã:";
            // 
            // dtg_khuyenmai
            // 
            this.dtg_khuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_khuyenmai.Location = new System.Drawing.Point(6, 240);
            this.dtg_khuyenmai.Name = "dtg_khuyenmai";
            this.dtg_khuyenmai.RowHeadersWidth = 51;
            this.dtg_khuyenmai.RowTemplate.Height = 29;
            this.dtg_khuyenmai.Size = new System.Drawing.Size(955, 598);
            this.dtg_khuyenmai.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_timkiemKM);
            this.groupBox1.Controls.Add(this.dtp_ngayketthuctimkiem);
            this.groupBox1.Controls.Add(this.dtp_ngaybatdautimkiem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_timkiemKM);
            this.groupBox1.Controls.Add(this.rdb_hethan);
            this.groupBox1.Controls.Add(this.rdb_conhan);
            this.groupBox1.Controls.Add(this.dtg_khuyenmai);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 844);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khuyến mãi";
            // 
            // btn_timkiemKM
            // 
            this.btn_timkiemKM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_timkiemKM.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_timkiemKM.IconColor = System.Drawing.Color.Black;
            this.btn_timkiemKM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_timkiemKM.IconSize = 25;
            this.btn_timkiemKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemKM.Location = new System.Drawing.Point(799, 145);
            this.btn_timkiemKM.Name = "btn_timkiemKM";
            this.btn_timkiemKM.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.btn_timkiemKM.Size = new System.Drawing.Size(134, 37);
            this.btn_timkiemKM.TabIndex = 42;
            this.btn_timkiemKM.Text = "LỌC";
            this.btn_timkiemKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemKM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timkiemKM.UseVisualStyleBackColor = true;
            // 
            // dtp_ngayketthuctimkiem
            // 
            this.dtp_ngayketthuctimkiem.Location = new System.Drawing.Point(466, 153);
            this.dtp_ngayketthuctimkiem.Name = "dtp_ngayketthuctimkiem";
            this.dtp_ngayketthuctimkiem.Size = new System.Drawing.Size(294, 27);
            this.dtp_ngayketthuctimkiem.TabIndex = 43;
            // 
            // dtp_ngaybatdautimkiem
            // 
            this.dtp_ngaybatdautimkiem.Location = new System.Drawing.Point(97, 153);
            this.dtp_ngaybatdautimkiem.Name = "dtp_ngaybatdautimkiem";
            this.dtp_ngaybatdautimkiem.Size = new System.Drawing.Size(294, 27);
            this.dtp_ngaybatdautimkiem.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Từ:";
            // 
            // tb_timkiemKM
            // 
            this.tb_timkiemKM.Location = new System.Drawing.Point(119, 207);
            this.tb_timkiemKM.Name = "tb_timkiemKM";
            this.tb_timkiemKM.PlaceholderText = "Nhập tên Chương trình khuyến mãi cần tìm ....";
            this.tb_timkiemKM.Size = new System.Drawing.Size(359, 27);
            this.tb_timkiemKM.TabIndex = 41;
            // 
            // rdb_hethan
            // 
            this.rdb_hethan.AutoSize = true;
            this.rdb_hethan.Location = new System.Drawing.Point(300, 52);
            this.rdb_hethan.Name = "rdb_hethan";
            this.rdb_hethan.Size = new System.Drawing.Size(82, 24);
            this.rdb_hethan.TabIndex = 41;
            this.rdb_hethan.TabStop = true;
            this.rdb_hethan.Text = "Hết hạn";
            this.rdb_hethan.UseVisualStyleBackColor = true;
            // 
            // rdb_conhan
            // 
            this.rdb_conhan.AutoSize = true;
            this.rdb_conhan.Location = new System.Drawing.Point(163, 52);
            this.rdb_conhan.Name = "rdb_conhan";
            this.rdb_conhan.Size = new System.Drawing.Size(84, 24);
            this.rdb_conhan.TabIndex = 42;
            this.rdb_conhan.TabStop = true;
            this.rdb_conhan.Text = "Còn hạn";
            this.rdb_conhan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày kết thúc";
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(183, 205);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(271, 27);
            this.dtp_ngaybatdau.TabIndex = 34;
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(183, 254);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(271, 27);
            this.dtp_ngayketthuc.TabIndex = 35;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(183, 300);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 24);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Còn hạn";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 346);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hết hạn";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mức giảm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_tenCTkm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_mucgiam);
            this.groupBox2.Controls.Add(this.tb_makm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.dtp_ngayketthuc);
            this.groupBox2.Controls.Add(this.dtp_ngaybatdau);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(991, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 444);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khuyến mãi";
            // 
            // tb_tenCTkm
            // 
            this.tb_tenCTkm.Location = new System.Drawing.Point(183, 105);
            this.tb_tenCTkm.Name = "tb_tenCTkm";
            this.tb_tenCTkm.Size = new System.Drawing.Size(271, 27);
            this.tb_tenCTkm.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tên chương trình:";
            // 
            // tb_mucgiam
            // 
            this.tb_mucgiam.Location = new System.Drawing.Point(183, 158);
            this.tb_mucgiam.Name = "tb_mucgiam";
            this.tb_mucgiam.Size = new System.Drawing.Size(271, 27);
            this.tb_mucgiam.TabIndex = 40;
            // 
            // tb_makm
            // 
            this.tb_makm.Location = new System.Drawing.Point(183, 45);
            this.tb_makm.Name = "tb_makm";
            this.tb_makm.Size = new System.Drawing.Size(271, 27);
            this.tb_makm.TabIndex = 39;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(1358, 482);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.btn_sua.Size = new System.Drawing.Size(176, 53);
            this.btn_sua.TabIndex = 40;
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
            this.btn_xoa.Location = new System.Drawing.Point(1176, 482);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(20, 2, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(176, 53);
            this.btn_xoa.TabIndex = 41;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Thời gian:";
            // 
            // QL_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 874);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_them);
            this.Name = "QL_KhuyenMai";
            this.Text = "QL_KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_khuyenmai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_khuyenmai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_hethan;
        private System.Windows.Forms.RadioButton rdb_conhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
        private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_mucgiam;
        private System.Windows.Forms.TextBox tb_makm;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_timkiemKM;
        private System.Windows.Forms.TextBox tb_tenCTkm;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_timkiemKM;
        private System.Windows.Forms.DateTimePicker dtp_ngayketthuctimkiem;
        private System.Windows.Forms.DateTimePicker dtp_ngaybatdautimkiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}