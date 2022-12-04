namespace DuAn1_Winform
{
    partial class ManHinhChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new FontAwesome.Sharp.IconButton();
            this.btn_thongke = new FontAwesome.Sharp.IconButton();
            this.btn_taikhoan = new FontAwesome.Sharp.IconButton();
            this.btn_nhanvien = new FontAwesome.Sharp.IconButton();
            this.btn_khuyenmai = new FontAwesome.Sharp.IconButton();
            this.btn_khachhang = new FontAwesome.Sharp.IconButton();
            this.btn_hoadon = new FontAwesome.Sharp.IconButton();
            this.btn_sanpham = new FontAwesome.Sharp.IconButton();
            this.btn_banhang = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_poster = new System.Windows.Forms.Panel();
            this.lb_timer = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_chucnang.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_poster.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chucnang
            // 
            this.panel_chucnang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_chucnang.Controls.Add(this.btn_dangxuat);
            this.panel_chucnang.Controls.Add(this.btn_thongke);
            this.panel_chucnang.Controls.Add(this.btn_taikhoan);
            this.panel_chucnang.Controls.Add(this.btn_nhanvien);
            this.panel_chucnang.Controls.Add(this.btn_khuyenmai);
            this.panel_chucnang.Controls.Add(this.btn_khachhang);
            this.panel_chucnang.Controls.Add(this.btn_hoadon);
            this.panel_chucnang.Controls.Add(this.btn_sanpham);
            this.panel_chucnang.Controls.Add(this.btn_banhang);
            this.panel_chucnang.Controls.Add(this.panel_logo);
            this.panel_chucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_chucnang.Location = new System.Drawing.Point(0, 0);
            this.panel_chucnang.Name = "panel_chucnang";
            this.panel_chucnang.Size = new System.Drawing.Size(233, 953);
            this.panel_chucnang.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dangxuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_dangxuat.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_dangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dangxuat.IconSize = 36;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 893);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(233, 60);
            this.btn_dangxuat.TabIndex = 9;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thongke.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_thongke.IconChar = FontAwesome.Sharp.IconChar.Signal;
            this.btn_thongke.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_thongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_thongke.IconSize = 36;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(0, 566);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_thongke.Size = new System.Drawing.Size(233, 60);
            this.btn_thongke.TabIndex = 8;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_taikhoan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_taikhoan.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btn_taikhoan.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_taikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_taikhoan.IconSize = 36;
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 506);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_taikhoan.Size = new System.Drawing.Size(233, 60);
            this.btn_taikhoan.TabIndex = 7;
            this.btn_taikhoan.Text = "Tài Khoản";
            this.btn_taikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taikhoan.UseVisualStyleBackColor = true;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nhanvien.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btn_nhanvien.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_nhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nhanvien.IconSize = 36;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 446);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_nhanvien.Size = new System.Drawing.Size(233, 60);
            this.btn_nhanvien.TabIndex = 6;
            this.btn_nhanvien.Text = "Nhân Viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.UseWaitCursor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_khuyenmai
            // 
            this.btn_khuyenmai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_khuyenmai.FlatAppearance.BorderSize = 0;
            this.btn_khuyenmai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khuyenmai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_khuyenmai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_khuyenmai.IconChar = FontAwesome.Sharp.IconChar.Percent;
            this.btn_khuyenmai.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_khuyenmai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_khuyenmai.IconSize = 36;
            this.btn_khuyenmai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai.Location = new System.Drawing.Point(0, 386);
            this.btn_khuyenmai.Name = "btn_khuyenmai";
            this.btn_khuyenmai.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_khuyenmai.Size = new System.Drawing.Size(233, 60);
            this.btn_khuyenmai.TabIndex = 5;
            this.btn_khuyenmai.Text = "Khuyễn Mãi";
            this.btn_khuyenmai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_khuyenmai.UseVisualStyleBackColor = true;
            this.btn_khuyenmai.Click += new System.EventHandler(this.btn_khuyenmai_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_khachhang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_khachhang.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_khachhang.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_khachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_khachhang.IconSize = 36;
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(0, 326);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_khachhang.Size = new System.Drawing.Size(233, 60);
            this.btn_khachhang.TabIndex = 4;
            this.btn_khachhang.Text = "Khách Hàng";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hoadon.FlatAppearance.BorderSize = 0;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hoadon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hoadon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btn_hoadon.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_hoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_hoadon.IconSize = 36;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 266);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_hoadon.Size = new System.Drawing.Size(233, 60);
            this.btn_hoadon.TabIndex = 3;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sanpham.FlatAppearance.BorderSize = 0;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sanpham.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btn_sanpham.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_sanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sanpham.IconSize = 36;
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(0, 206);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_sanpham.Size = new System.Drawing.Size(233, 60);
            this.btn_sanpham.TabIndex = 2;
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sanpham.UseVisualStyleBackColor = true;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_banhang.FlatAppearance.BorderSize = 0;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_banhang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_banhang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_banhang.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_banhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_banhang.IconSize = 36;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(0, 146);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_banhang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_banhang.Size = new System.Drawing.Size(233, 60);
            this.btn_banhang.TabIndex = 1;
            this.btn_banhang.Text = "Bán Hàng";
            this.btn_banhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_banhang.UseVisualStyleBackColor = true;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(233, 146);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_poster
            // 
            this.panel_poster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_poster.Controls.Add(this.lb_timer);
            this.panel_poster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_poster.Location = new System.Drawing.Point(233, 0);
            this.panel_poster.Name = "panel_poster";
            this.panel_poster.Size = new System.Drawing.Size(1549, 81);
            this.panel_poster.TabIndex = 1;
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Location = new System.Drawing.Point(1283, 30);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(75, 20);
            this.lb_timer.TabIndex = 0;
            this.lb_timer.Text = "Thời Gian:";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel_main.Location = new System.Drawing.Point(233, 81);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1549, 872);
            this.panel_main.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManHinhChinh
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1782, 953);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_poster);
            this.Controls.Add(this.panel_chucnang);
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhChinh";
            this.panel_chucnang.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_poster.ResumeLayout(false);
            this.panel_poster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_chucnang;
        private FontAwesome.Sharp.IconButton btn_nhanvien;
        private FontAwesome.Sharp.IconButton btn_khuyenmai;
        private FontAwesome.Sharp.IconButton btn_khachhang;
        private FontAwesome.Sharp.IconButton btn_hoadon;
        private FontAwesome.Sharp.IconButton btn_sanpham;
        private FontAwesome.Sharp.IconButton btn_banhang;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton btn_taikhoan;
        private System.Windows.Forms.Panel panel_poster;
        private System.Windows.Forms.Panel panel_main;
        private FontAwesome.Sharp.IconButton btn_thongke;
        private FontAwesome.Sharp.IconButton btn_dangxuat;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}