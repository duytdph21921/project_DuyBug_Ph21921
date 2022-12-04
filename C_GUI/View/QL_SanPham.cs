using B_BUS.IService;
using B_BUS.Service;
using B_BUS.ViewModel;
using C_GUI.View;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Winform
{
    public partial class QL_SanPham : Form
    {
        IAnhService _IAnhview;
        Guid idanh;
        string imageUrl = "";
        public QL_SanPham()
        {
            InitializeComponent();
            _IAnhview = new AnhService();
            //loadataa();
            OpenChildForm(new FrmThongTinSanPham());


        }
        private Form productANDImage;
        private void OpenChildForm(Form childform)
        {
            if (productANDImage != null)
            {
                productANDImage.Close();
            }
            productANDImage = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_Ql_SanPham.Controls.Add(childform);
            panel_Ql_SanPham.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }


        /*private void BTN_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "";
            ofd.ShowDialog(); //sau khi chọn file thì of chưa 1 đường dẫn 

            DialogResult result = MessageBox.Show("bạn có muốn đổi avatar không", " đổi avata", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("thay ảnh thành công");
                PCB_Test.Image = Image.FromFile(ofd.FileName);

            }
            else
            {
                MessageBox.Show("bạn không thay nữa à");
            }
            imageUrl = ofd.FileName; // gán đường dẫn sau khi đã chọn
        }*/

       /* public AnhViewModel them()
        {
            AnhViewModel anhViewModel = new AnhViewModel()
            {
                // Id = new Guid(),
                Ma = TB_Ma.Text,
                Ten = TB_Ten.Text,
                Link = imageUrl


            };
            return anhViewModel;
        }*/
     /*   private void BTN_ThemTest_Click(object sender, EventArgs e)
        {
           MessageBox.Show(_IAnhview.add(them()));
            loadataa();

        }*/
      /*  public void loadataa()
        {
            dtg_show.ColumnCount = 6;
            dtg_show.Rows.Clear();
            dtg_show.Columns[0].Name = "id";
            dtg_show.Columns[1].Name = "ma";
            dtg_show.Columns[2].Name = "ten";
            dtg_show.Columns[3].Name = "link";

            dtg_show.Columns[0].Visible = false;
            //dtg_show.Columns[3].Visible = false;
            foreach (var item in _IAnhview.GetAll())
            {
                dtg_show.Rows.Add(item.id, item.Ma, item.Ten, item.Link);
            }

        }*/

        /*private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idanh = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString());
           
            PCB_Test.Image = Image.FromFile(_IAnhview.GetAll().FirstOrDefault(c => c.id == idanh).Link) ;
        }
*/
        private void sảnPhảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongTinSanPham());
        }

        private void thuộcTínhXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinvsAnh());
        }
    }
}
