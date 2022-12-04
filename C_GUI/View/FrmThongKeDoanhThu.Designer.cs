namespace DuAn1_Winform
{
    partial class FrmThongKeDoanhThu
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
            this.panel_dtngay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_dtthang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.paneldtnam = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.rdb_hoadonbihuy = new System.Windows.Forms.RadioButton();
            this.rdb_hoadondathanhtoan = new System.Windows.Forms.RadioButton();
            this.dtg_hoadon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_dtngay.SuspendLayout();
            this.panel_dtthang.SuspendLayout();
            this.paneldtnam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_dtngay
            // 
            this.panel_dtngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_dtngay.Controls.Add(this.label1);
            this.panel_dtngay.Controls.Add(this.iconButton1);
            this.panel_dtngay.Location = new System.Drawing.Point(65, 22);
            this.panel_dtngay.Name = "panel_dtngay";
            this.panel_dtngay.Size = new System.Drawing.Size(277, 133);
            this.panel_dtngay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(36, 16);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(208, 50);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Doanh Thu Ngày";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel_dtthang
            // 
            this.panel_dtthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_dtthang.Controls.Add(this.label2);
            this.panel_dtthang.Controls.Add(this.iconButton2);
            this.panel_dtthang.Location = new System.Drawing.Point(644, 22);
            this.panel_dtthang.Name = "panel_dtthang";
            this.panel_dtthang.Size = new System.Drawing.Size(277, 133);
            this.panel_dtthang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(36, 16);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(208, 50);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Doanh Thu Tháng";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // paneldtnam
            // 
            this.paneldtnam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.paneldtnam.Controls.Add(this.label3);
            this.paneldtnam.Controls.Add(this.iconButton3);
            this.paneldtnam.Location = new System.Drawing.Point(1191, 22);
            this.paneldtnam.Name = "paneldtnam";
            this.paneldtnam.Size = new System.Drawing.Size(277, 133);
            this.paneldtnam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(36, 16);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(208, 50);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Doanh Thu Năm";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_timkiem);
            this.groupBox1.Controls.Add(this.rdb_hoadonbihuy);
            this.groupBox1.Controls.Add(this.rdb_hoadondathanhtoan);
            this.groupBox1.Controls.Add(this.dtg_hoadon);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1520, 562);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tìm kiếm:";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(97, 98);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.PlaceholderText = "Nhập vào tên sản phẩm cần tìm kiếm ...";
            this.tb_timkiem.Size = new System.Drawing.Size(420, 27);
            this.tb_timkiem.TabIndex = 23;
            // 
            // rdb_hoadonbihuy
            // 
            this.rdb_hoadonbihuy.AutoSize = true;
            this.rdb_hoadonbihuy.Location = new System.Drawing.Point(897, 97);
            this.rdb_hoadonbihuy.Name = "rdb_hoadonbihuy";
            this.rdb_hoadonbihuy.Size = new System.Drawing.Size(132, 24);
            this.rdb_hoadonbihuy.TabIndex = 22;
            this.rdb_hoadonbihuy.TabStop = true;
            this.rdb_hoadonbihuy.Text = "Hóa đơn bị hủy";
            this.rdb_hoadonbihuy.UseVisualStyleBackColor = true;
            // 
            // rdb_hoadondathanhtoan
            // 
            this.rdb_hoadondathanhtoan.AutoSize = true;
            this.rdb_hoadondathanhtoan.Location = new System.Drawing.Point(632, 97);
            this.rdb_hoadondathanhtoan.Name = "rdb_hoadondathanhtoan";
            this.rdb_hoadondathanhtoan.Size = new System.Drawing.Size(184, 24);
            this.rdb_hoadondathanhtoan.TabIndex = 21;
            this.rdb_hoadondathanhtoan.TabStop = true;
            this.rdb_hoadondathanhtoan.Text = "Hóa đơn đã thanh toán";
            this.rdb_hoadondathanhtoan.UseVisualStyleBackColor = true;
            // 
            // dtg_hoadon
            // 
            this.dtg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadon.Location = new System.Drawing.Point(6, 142);
            this.dtg_hoadon.Name = "dtg_hoadon";
            this.dtg_hoadon.RowHeadersWidth = 51;
            this.dtg_hoadon.RowTemplate.Height = 29;
            this.dtg_hoadon.Size = new System.Drawing.Size(1508, 457);
            this.dtg_hoadon.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doanh thu từ ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(794, 217);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(314, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "tới ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1165, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "là:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1209, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 27);
            this.textBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1453, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "VNĐ";
            // 
            // FrmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1546, 849);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paneldtnam);
            this.Controls.Add(this.panel_dtthang);
            this.Controls.Add(this.panel_dtngay);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeDoanhThu";
            this.Text = "FrmThongKeDoanhThu";
            this.panel_dtngay.ResumeLayout(false);
            this.panel_dtngay.PerformLayout();
            this.panel_dtthang.ResumeLayout(false);
            this.panel_dtthang.PerformLayout();
            this.paneldtnam.ResumeLayout(false);
            this.paneldtnam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_dtngay;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_dtthang;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel paneldtnam;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_hoadon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.RadioButton rdb_hoadonbihuy;
        private System.Windows.Forms.RadioButton rdb_hoadondathanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}