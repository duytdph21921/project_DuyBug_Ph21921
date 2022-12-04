namespace DuAn1_Winform
{
    partial class QL_HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.dgrid_HoaDonCHiTiet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtTongTienHD = new System.Windows.Forms.TextBox();
            this.txtChiPhiKhac = new System.Windows.Forms.TextBox();
            this.txtTongTienSP = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdb_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.rdb_chuathanhtoan = new System.Windows.Forms.RadioButton();
            this.rdb_tienmat = new System.Windows.Forms.RadioButton();
            this.rdb_chuyenkhoan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCHiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(-5, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2473, 5);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(-5, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2473, 8);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lịch sử giao dịch";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(401, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(1628, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 53);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hóa đơn chi tiết";
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(50, 240);
            this.dgrid_HoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 51;
            this.dgrid_HoaDon.RowTemplate.Height = 29;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(957, 1133);
            this.dgrid_HoaDon.TabIndex = 10;
            // 
            // dgrid_HoaDonCHiTiet
            // 
            this.dgrid_HoaDonCHiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonCHiTiet.Location = new System.Drawing.Point(1126, 240);
            this.dgrid_HoaDonCHiTiet.Margin = new System.Windows.Forms.Padding(5);
            this.dgrid_HoaDonCHiTiet.Name = "dgrid_HoaDonCHiTiet";
            this.dgrid_HoaDonCHiTiet.RowHeadersWidth = 51;
            this.dgrid_HoaDonCHiTiet.RowTemplate.Height = 29;
            this.dgrid_HoaDonCHiTiet.Size = new System.Drawing.Size(1342, 374);
            this.dgrid_HoaDonCHiTiet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1216, 680);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã HĐ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1216, 771);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khách hàng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1216, 862);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "SDT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1216, 962);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "Loại thanh toán :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1216, 1064);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 38);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ghi chú :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1864, 962);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 38);
            this.label12.TabIndex = 19;
            this.label12.Text = "Trạng thái :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1862, 766);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 38);
            this.label13.TabIndex = 20;
            this.label13.Text = "Chi phí khác : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1864, 848);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 38);
            this.label14.TabIndex = 21;
            this.label14.Text = "Tổng tiền HĐ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(1864, 683);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 38);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tổng tiền SP:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(1461, 674);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(322, 39);
            this.txtMaHD.TabIndex = 24;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1461, 856);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(322, 39);
            this.txtSDT.TabIndex = 27;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(1461, 770);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(322, 39);
            this.txtKhachHang.TabIndex = 28;
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.Location = new System.Drawing.Point(2117, 846);
            this.txtTongTienHD.Margin = new System.Windows.Forms.Padding(5);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.Size = new System.Drawing.Size(322, 39);
            this.txtTongTienHD.TabIndex = 30;
            // 
            // txtChiPhiKhac
            // 
            this.txtChiPhiKhac.Location = new System.Drawing.Point(2117, 766);
            this.txtChiPhiKhac.Margin = new System.Windows.Forms.Padding(5);
            this.txtChiPhiKhac.Name = "txtChiPhiKhac";
            this.txtChiPhiKhac.Size = new System.Drawing.Size(322, 39);
            this.txtChiPhiKhac.TabIndex = 31;
            // 
            // txtTongTienSP
            // 
            this.txtTongTienSP.Location = new System.Drawing.Point(2117, 682);
            this.txtTongTienSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtTongTienSP.Name = "txtTongTienSP";
            this.txtTongTienSP.Size = new System.Drawing.Size(322, 39);
            this.txtTongTienSP.TabIndex = 32;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(1216, 1118);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1224, 190);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // rdb_dathanhtoan
            // 
            this.rdb_dathanhtoan.AutoSize = true;
            this.rdb_dathanhtoan.Location = new System.Drawing.Point(2117, 960);
            this.rdb_dathanhtoan.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_dathanhtoan.Name = "rdb_dathanhtoan";
            this.rdb_dathanhtoan.Size = new System.Drawing.Size(198, 36);
            this.rdb_dathanhtoan.TabIndex = 34;
            this.rdb_dathanhtoan.TabStop = true;
            this.rdb_dathanhtoan.Text = "Đã thanh toán";
            this.rdb_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdb_chuathanhtoan
            // 
            this.rdb_chuathanhtoan.AutoSize = true;
            this.rdb_chuathanhtoan.Location = new System.Drawing.Point(2117, 1034);
            this.rdb_chuathanhtoan.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_chuathanhtoan.Name = "rdb_chuathanhtoan";
            this.rdb_chuathanhtoan.Size = new System.Drawing.Size(224, 36);
            this.rdb_chuathanhtoan.TabIndex = 35;
            this.rdb_chuathanhtoan.TabStop = true;
            this.rdb_chuathanhtoan.Text = "Chưa thanh toán";
            this.rdb_chuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdb_tienmat
            // 
            this.rdb_tienmat.AutoSize = true;
            this.rdb_tienmat.Location = new System.Drawing.Point(1474, 1034);
            this.rdb_tienmat.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_tienmat.Name = "rdb_tienmat";
            this.rdb_tienmat.Size = new System.Drawing.Size(139, 36);
            this.rdb_tienmat.TabIndex = 37;
            this.rdb_tienmat.TabStop = true;
            this.rdb_tienmat.Text = "Tiền mặt";
            this.rdb_tienmat.UseVisualStyleBackColor = true;
            // 
            // rdb_chuyenkhoan
            // 
            this.rdb_chuyenkhoan.AutoSize = true;
            this.rdb_chuyenkhoan.Location = new System.Drawing.Point(1474, 960);
            this.rdb_chuyenkhoan.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_chuyenkhoan.Name = "rdb_chuyenkhoan";
            this.rdb_chuyenkhoan.Size = new System.Drawing.Size(200, 36);
            this.rdb_chuyenkhoan.TabIndex = 36;
            this.rdb_chuyenkhoan.TabStop = true;
            this.rdb_chuyenkhoan.Text = "Chuyển khoản";
            this.rdb_chuyenkhoan.UseVisualStyleBackColor = true;
            // 
            // QL_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(2488, 1387);
            this.Controls.Add(this.rdb_tienmat);
            this.Controls.Add(this.rdb_chuyenkhoan);
            this.Controls.Add(this.rdb_chuathanhtoan);
            this.Controls.Add(this.rdb_dathanhtoan);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtTongTienSP);
            this.Controls.Add(this.txtChiPhiKhac);
            this.Controls.Add(this.txtTongTienHD);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgrid_HoaDonCHiTiet);
            this.Controls.Add(this.dgrid_HoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QL_HoaDon";
            this.Text = "QL_HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCHiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrid_HoaDon;
        private System.Windows.Forms.DataGridView dgrid_HoaDonCHiTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTienHD;
        private System.Windows.Forms.TextBox txtChiPhiKhac;
        private System.Windows.Forms.TextBox txtTongTienSP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdb_dathanhtoan;
        private System.Windows.Forms.RadioButton rdb_chuathanhtoan;
        private System.Windows.Forms.RadioButton rdb_tienmat;
        private System.Windows.Forms.RadioButton rdb_chuyenkhoan;
    }
}