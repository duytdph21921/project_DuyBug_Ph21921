namespace C_GUI.View
{
    partial class FormThongTinvsAnh
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
            this.BTN_Xoa = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Timkiem = new System.Windows.Forms.TextBox();
            this.GB_ThuocTinh = new System.Windows.Forms.GroupBox();
            this.RD_ChucVu = new System.Windows.Forms.RadioButton();
            this.RD_Anh = new System.Windows.Forms.RadioButton();
            this.RD_KhoiDong = new System.Windows.Forms.RadioButton();
            this.RD_DongCo = new System.Windows.Forms.RadioButton();
            this.RD_NSX = new System.Windows.Forms.RadioButton();
            this.RD_MauSac = new System.Windows.Forms.RadioButton();
            this.RD_LoaiXe = new System.Windows.Forms.RadioButton();
            this.PCB_Test = new FontAwesome.Sharp.IconPictureBox();
            this.BTN_ThemAnh = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Ten = new System.Windows.Forms.TextBox();
            this.TB_Ma = new System.Windows.Forms.TextBox();
            this.BTN_Them = new FontAwesome.Sharp.IconButton();
            this.PL_khung = new System.Windows.Forms.Panel();
            this.GB_ThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Sua = new FontAwesome.Sharp.IconButton();
            this.GB_ThuocTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Test)).BeginInit();
            this.PL_khung.SuspendLayout();
            this.GB_ThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Xoa
            // 
            this.BTN_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Xoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Xoa.IconColor = System.Drawing.Color.Black;
            this.BTN_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Xoa.Location = new System.Drawing.Point(894, 201);
            this.BTN_Xoa.Name = "BTN_Xoa";
            this.BTN_Xoa.Size = new System.Drawing.Size(232, 99);
            this.BTN_Xoa.TabIndex = 7;
            this.BTN_Xoa.Text = "XÓA";
            this.BTN_Xoa.UseVisualStyleBackColor = true;
            this.BTN_Xoa.Click += new System.EventHandler(this.BTN_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm Kiếm";
            // 
            // TB_Timkiem
            // 
            this.TB_Timkiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TB_Timkiem.Location = new System.Drawing.Point(166, 738);
            this.TB_Timkiem.Name = "TB_Timkiem";
            this.TB_Timkiem.Size = new System.Drawing.Size(913, 39);
            this.TB_Timkiem.TabIndex = 17;
            this.TB_Timkiem.Text = "Nhập nhưng thứ bạn mong muốn vào đây";
            // 
            // GB_ThuocTinh
            // 
            this.GB_ThuocTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GB_ThuocTinh.Controls.Add(this.RD_ChucVu);
            this.GB_ThuocTinh.Controls.Add(this.RD_Anh);
            this.GB_ThuocTinh.Controls.Add(this.RD_KhoiDong);
            this.GB_ThuocTinh.Controls.Add(this.RD_DongCo);
            this.GB_ThuocTinh.Controls.Add(this.RD_NSX);
            this.GB_ThuocTinh.Controls.Add(this.RD_MauSac);
            this.GB_ThuocTinh.Controls.Add(this.RD_LoaiXe);
            this.GB_ThuocTinh.Location = new System.Drawing.Point(1157, 23);
            this.GB_ThuocTinh.Name = "GB_ThuocTinh";
            this.GB_ThuocTinh.Size = new System.Drawing.Size(1351, 796);
            this.GB_ThuocTinh.TabIndex = 5;
            this.GB_ThuocTinh.TabStop = false;
            this.GB_ThuocTinh.Text = "Thuộc Tính";
            // 
            // RD_ChucVu
            // 
            this.RD_ChucVu.AutoSize = true;
            this.RD_ChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_ChucVu.Location = new System.Drawing.Point(294, 498);
            this.RD_ChucVu.Name = "RD_ChucVu";
            this.RD_ChucVu.Size = new System.Drawing.Size(168, 40);
            this.RD_ChucVu.TabIndex = 6;
            this.RD_ChucVu.TabStop = true;
            this.RD_ChucVu.Text = "Chức Vụ";
            this.RD_ChucVu.UseVisualStyleBackColor = true;
            this.RD_ChucVu.CheckedChanged += new System.EventHandler(this.RD_ChucVu_CheckedChanged);
            // 
            // RD_Anh
            // 
            this.RD_Anh.AutoSize = true;
            this.RD_Anh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_Anh.Location = new System.Drawing.Point(913, 395);
            this.RD_Anh.Name = "RD_Anh";
            this.RD_Anh.Size = new System.Drawing.Size(105, 40);
            this.RD_Anh.TabIndex = 5;
            this.RD_Anh.TabStop = true;
            this.RD_Anh.Text = "Ảnh";
            this.RD_Anh.UseVisualStyleBackColor = true;
            this.RD_Anh.CheckedChanged += new System.EventHandler(this.RD_Anh_CheckedChanged);
            // 
            // RD_KhoiDong
            // 
            this.RD_KhoiDong.AutoSize = true;
            this.RD_KhoiDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_KhoiDong.Location = new System.Drawing.Point(913, 280);
            this.RD_KhoiDong.Name = "RD_KhoiDong";
            this.RD_KhoiDong.Size = new System.Drawing.Size(198, 40);
            this.RD_KhoiDong.TabIndex = 4;
            this.RD_KhoiDong.TabStop = true;
            this.RD_KhoiDong.Text = "Khởi Động";
            this.RD_KhoiDong.UseVisualStyleBackColor = true;
            this.RD_KhoiDong.CheckedChanged += new System.EventHandler(this.RD_KhoiDong_CheckedChanged);
            // 
            // RD_DongCo
            // 
            this.RD_DongCo.AutoSize = true;
            this.RD_DongCo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_DongCo.Location = new System.Drawing.Point(621, 395);
            this.RD_DongCo.Name = "RD_DongCo";
            this.RD_DongCo.Size = new System.Drawing.Size(168, 40);
            this.RD_DongCo.TabIndex = 3;
            this.RD_DongCo.TabStop = true;
            this.RD_DongCo.Text = "Động Cơ";
            this.RD_DongCo.UseVisualStyleBackColor = true;
            this.RD_DongCo.CheckedChanged += new System.EventHandler(this.RD_DongCo_CheckedChanged);
            // 
            // RD_NSX
            // 
            this.RD_NSX.AutoSize = true;
            this.RD_NSX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_NSX.Location = new System.Drawing.Point(612, 280);
            this.RD_NSX.Name = "RD_NSX";
            this.RD_NSX.Size = new System.Drawing.Size(239, 40);
            this.RD_NSX.TabIndex = 2;
            this.RD_NSX.TabStop = true;
            this.RD_NSX.Text = "Nhà Sản Xuất";
            this.RD_NSX.UseVisualStyleBackColor = true;
            this.RD_NSX.CheckedChanged += new System.EventHandler(this.RD_NSX_CheckedChanged);
            // 
            // RD_MauSac
            // 
            this.RD_MauSac.AutoSize = true;
            this.RD_MauSac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_MauSac.Location = new System.Drawing.Point(294, 395);
            this.RD_MauSac.Name = "RD_MauSac";
            this.RD_MauSac.Size = new System.Drawing.Size(167, 40);
            this.RD_MauSac.TabIndex = 1;
            this.RD_MauSac.TabStop = true;
            this.RD_MauSac.Text = "Màu Sắc";
            this.RD_MauSac.UseVisualStyleBackColor = true;
            this.RD_MauSac.CheckedChanged += new System.EventHandler(this.RD_MauSac_CheckedChanged);
            // 
            // RD_LoaiXe
            // 
            this.RD_LoaiXe.AutoSize = true;
            this.RD_LoaiXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RD_LoaiXe.Location = new System.Drawing.Point(294, 280);
            this.RD_LoaiXe.Name = "RD_LoaiXe";
            this.RD_LoaiXe.Size = new System.Drawing.Size(153, 40);
            this.RD_LoaiXe.TabIndex = 0;
            this.RD_LoaiXe.TabStop = true;
            this.RD_LoaiXe.Text = "Loại Xe";
            this.RD_LoaiXe.UseVisualStyleBackColor = true;
            this.RD_LoaiXe.CheckedChanged += new System.EventHandler(this.RD_LoaiXe_CheckedChanged);
            // 
            // PCB_Test
            // 
            this.PCB_Test.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PCB_Test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PCB_Test.IconChar = FontAwesome.Sharp.IconChar.User;
            this.PCB_Test.IconColor = System.Drawing.SystemColors.ControlText;
            this.PCB_Test.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PCB_Test.IconSize = 298;
            this.PCB_Test.Location = new System.Drawing.Point(95, 129);
            this.PCB_Test.Name = "PCB_Test";
            this.PCB_Test.Size = new System.Drawing.Size(298, 423);
            this.PCB_Test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCB_Test.TabIndex = 16;
            this.PCB_Test.TabStop = false;
            // 
            // BTN_ThemAnh
            // 
            this.BTN_ThemAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_ThemAnh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_ThemAnh.IconColor = System.Drawing.Color.Black;
            this.BTN_ThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_ThemAnh.Location = new System.Drawing.Point(581, 417);
            this.BTN_ThemAnh.Name = "BTN_ThemAnh";
            this.BTN_ThemAnh.Size = new System.Drawing.Size(187, 79);
            this.BTN_ThemAnh.TabIndex = 11;
            this.BTN_ThemAnh.Text = "Thêm Ảnh";
            this.BTN_ThemAnh.UseVisualStyleBackColor = true;
            this.BTN_ThemAnh.Click += new System.EventHandler(this.BTN_ThemAnh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(507, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 36);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(507, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 36);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mã";
            // 
            // TB_Ten
            // 
            this.TB_Ten.Location = new System.Drawing.Point(594, 235);
            this.TB_Ten.Name = "TB_Ten";
            this.TB_Ten.Size = new System.Drawing.Size(273, 39);
            this.TB_Ten.TabIndex = 13;
            // 
            // TB_Ma
            // 
            this.TB_Ma.Location = new System.Drawing.Point(594, 147);
            this.TB_Ma.Name = "TB_Ma";
            this.TB_Ma.Size = new System.Drawing.Size(273, 39);
            this.TB_Ma.TabIndex = 12;
            // 
            // BTN_Them
            // 
            this.BTN_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Them.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Them.IconColor = System.Drawing.Color.Black;
            this.BTN_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Them.Location = new System.Drawing.Point(802, 417);
            this.BTN_Them.Name = "BTN_Them";
            this.BTN_Them.Size = new System.Drawing.Size(232, 99);
            this.BTN_Them.TabIndex = 6;
            this.BTN_Them.Text = "THÊM";
            this.BTN_Them.UseVisualStyleBackColor = true;
            this.BTN_Them.Click += new System.EventHandler(this.BTN_Them_Click);
            // 
            // PL_khung
            // 
            this.PL_khung.BackColor = System.Drawing.Color.LightCyan;
            this.PL_khung.Controls.Add(this.label1);
            this.PL_khung.Controls.Add(this.TB_Timkiem);
            this.PL_khung.Controls.Add(this.GB_ThuocTinh);
            this.PL_khung.Controls.Add(this.GB_ThongTin);
            this.PL_khung.Controls.Add(this.dtg_Show);
            this.PL_khung.Controls.Add(this.panel1);
            this.PL_khung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PL_khung.Location = new System.Drawing.Point(0, 0);
            this.PL_khung.Name = "PL_khung";
            this.PL_khung.Size = new System.Drawing.Size(2515, 1411);
            this.PL_khung.TabIndex = 1;
            // 
            // GB_ThongTin
            // 
            this.GB_ThongTin.Controls.Add(this.groupBox1);
            this.GB_ThongTin.Location = new System.Drawing.Point(4, 6);
            this.GB_ThongTin.Name = "GB_ThongTin";
            this.GB_ThongTin.Size = new System.Drawing.Size(1137, 698);
            this.GB_ThongTin.TabIndex = 3;
            this.GB_ThongTin.TabStop = false;
            this.GB_ThongTin.Text = "Thông Tin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.BTN_Them);
            this.groupBox1.Controls.Add(this.BTN_ThemAnh);
            this.groupBox1.Controls.Add(this.PCB_Test);
            this.groupBox1.Controls.Add(this.TB_Ma);
            this.groupBox1.Controls.Add(this.TB_Ten);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 690);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dtg_Show
            // 
            this.dtg_Show.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.GridColor = System.Drawing.Color.LemonChiffon;
            this.dtg_Show.Location = new System.Drawing.Point(4, 813);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 82;
            this.dtg_Show.RowTemplate.Height = 41;
            this.dtg_Show.Size = new System.Drawing.Size(1137, 565);
            this.dtg_Show.TabIndex = 2;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BTN_Sua);
            this.panel1.Controls.Add(this.BTN_Xoa);
            this.panel1.Location = new System.Drawing.Point(1159, 824);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 563);
            this.panel1.TabIndex = 18;
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Sua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Sua.IconColor = System.Drawing.Color.Black;
            this.BTN_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Sua.Location = new System.Drawing.Point(556, 201);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(232, 99);
            this.BTN_Sua.TabIndex = 8;
            this.BTN_Sua.Text = "SỬA";
            this.BTN_Sua.UseVisualStyleBackColor = true;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // FormThongTinvsAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2515, 1411);
            this.Controls.Add(this.PL_khung);
            this.Name = "FormThongTinvsAnh";
            this.ShowInTaskbar = false;
            this.Text = "FormThongTinvsAnh";
            this.GB_ThuocTinh.ResumeLayout(false);
            this.GB_ThuocTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Test)).EndInit();
            this.PL_khung.ResumeLayout(false);
            this.PL_khung.PerformLayout();
            this.GB_ThongTin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BTN_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Timkiem;
        private System.Windows.Forms.GroupBox GB_ThuocTinh;
        private System.Windows.Forms.RadioButton RD_ChucVu;
        private System.Windows.Forms.RadioButton RD_Anh;
        private System.Windows.Forms.RadioButton RD_KhoiDong;
        private System.Windows.Forms.RadioButton RD_DongCo;
        private System.Windows.Forms.RadioButton RD_NSX;
        private System.Windows.Forms.RadioButton RD_MauSac;
        private System.Windows.Forms.RadioButton RD_LoaiXe;
        private FontAwesome.Sharp.IconButton BTN_Them;
        private FontAwesome.Sharp.IconPictureBox PCB_Test;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_Ten;
        private System.Windows.Forms.TextBox TB_Ma;
        private FontAwesome.Sharp.IconButton BTN_ThemAnh;
        private System.Windows.Forms.Panel PL_khung;
        private System.Windows.Forms.GroupBox GB_ThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Show;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BTN_Sua;
    }
}