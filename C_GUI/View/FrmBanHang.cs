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
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            
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
            panelAddHoaDon.Controls.Add(childform);
            panelAddHoaDon.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btn_AddHoaDon_Click(object sender, EventArgs e)
        {

           DialogResult result = MessageBox.Show(" Bạn có muốn tạo hóa đơn ", "Thông báo ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
           
            switch (result)
            {
                case DialogResult.Yes:
                    OpenChildForm(new FrmHoaDonChiTiet());
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            plGiaoHang.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plGiaoHang.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_GiaoHang.Checked == true)
            {
                cbxTaiQuay.Checked = false;
                plGiaoHang.Visible = true;
            }
        }

        private void cbxTaiQuay_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxTaiQuay.Checked == true)
            {
                cbx_GiaoHang.Checked = false;
            }
        }

        private void cbx_ChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_ChuyenKhoan.Checked == true)
            {
                cbx_TienMat.Checked = false;
            }
        }

        private void cbx_TienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_TienMat.Checked == true)
            {
                cbx_ChuyenKhoan.Checked = false;
            }
        }
    }
}
