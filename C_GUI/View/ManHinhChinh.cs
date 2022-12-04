using FrmDangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Winform
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
            //OpenChildForm(new FrmBanHang());
            //btnColorSetting(btn_banhang, null);
            timer1.Start();

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {                                    
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childform);
            panel_main.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void btnColorSetting(object sender, EventArgs e)
        {
            foreach (Control c in panel_chucnang.Controls)
            {
                c.BackColor = Color.FromArgb(51, 51, 76);
                //c.ForeColor = Color.WhiteSmoke;
            }
            Control click = (Control)sender;
            click.BackColor = Color.Teal;

        }
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang());
            //btn_banhang.BackColor = Color.FromArgb(51, 51, 76);
            btnColorSetting(btn_banhang,null);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_SanPham());
            btnColorSetting(btn_sanpham, null);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_HoaDon());
            btnColorSetting(btn_hoadon, null);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_KhachHang());
            btnColorSetting(btn_khachhang, null);
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_KhuyenMai());
            btnColorSetting(btn_khuyenmai, null);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_NhanVien());
            btnColorSetting(btn_nhanvien, null);
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QL_TaiKhoan());
            btnColorSetting(btn_taikhoan, null);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
            btnColorSetting(btn_thongke, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_timer.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất hay không ?","Thông báo !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap f = new FormDangNhap();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
