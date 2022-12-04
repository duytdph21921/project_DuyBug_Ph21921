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
    public partial class QL_TaiKhoan : Form
    {
        public QL_TaiKhoan()
        {
            InitializeComponent();
            OpenChildForm(new FrmThongTinTaiKhoan());
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
            panel_ql_taikhoan.Controls.Add(childform);
           panel_ql_taikhoan.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongTinTaiKhoan());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoiMK());
        }
    }
}
