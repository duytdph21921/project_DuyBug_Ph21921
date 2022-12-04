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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            OpenChildForm(new FrmThongKeDoanhThu());
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
            panel_thongke.Controls.Add(childform);
            panel_thongke.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKeDoanhThu());
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKeNhanSu());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKeSanPham());
        }
    }
}
