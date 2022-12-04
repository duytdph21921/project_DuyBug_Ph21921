using B_BUS.IService;
using B_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_GUI.View
{
    public partial class FrmThongTinSanPham : Form
    {
        IAnhService _IAnhservice;
        IMauSacService _IMauSacService;
        INsxService _INsxService;
        IDongCoService _IDongcoService;
        IKhoiDongService _IkhoiDongService;
        ILoaiXeService _IloaiXeService;
        IChucVuService _IChucVuService;
        IChiTietXeService _IChiTietXeService;
        public FrmThongTinSanPham()
        {
            InitializeComponent();
            _IAnhservice = new AnhService();
            _IChucVuService = new ChuVuService();
            _IMauSacService = new MauSacService();
            _IDongcoService = new DongCoService();
            _IkhoiDongService = new KhoiDongService();
            _IloaiXeService = new LoaiXeService();
            _INsxService = new NsxService();
            _IChiTietXeService = new ChiTietXeService();
            load();
            loadanh();
        }
        public void load()
        {
          

            dtg_sanpham.ColumnCount = 17;
            dtg_sanpham.Rows.Clear();
            dtg_sanpham.Columns[0].Name = "id";
            dtg_sanpham.Columns[4].Name = "Màu";
            dtg_sanpham.Columns[2].Name = "Nhà Sản Xuất";
            dtg_sanpham.Columns[3].Name = "Loại Xe";
            dtg_sanpham.Columns[1].Name = "Sản Phẩm";
            dtg_sanpham.Columns[13].Name = "Động Cơ";
            dtg_sanpham.Columns[14].Name = "Khởi Động";
            dtg_sanpham.Columns[7].Name = "Ngày Nhập";
            dtg_sanpham.Columns[8].Name = "Năm Bảo Hành";
            dtg_sanpham.Columns[9].Name = "Số khung";
            dtg_sanpham.Columns[10].Name = "Số Máy";
            dtg_sanpham.Columns[11].Name = "Dung Tích Bình Xăng";
            dtg_sanpham.Columns[12].Name = "Mô Tả";
            dtg_sanpham.Columns[5].Name = "Số Lượng";
            dtg_sanpham.Columns[6].Name = "Giá Bán";
            dtg_sanpham.Columns[15].Name = "Giá Nhập";
            dtg_sanpham.Columns[16].Name = "Trạng Thái";
            dtg_sanpham.Columns[0].Visible = false;

            foreach (var item in _IChiTietXeService.Getall())
            {
                dtg_sanpham.Rows.Add(item.id,item.MauSac,item.NSX,
                    item.LoaiXe,item.SanPham,item.DongCo,item.KhoiDong,
                   item.NgayNhap,item.namBh,item.soKhung,item.soMay,
                   item.binhXang,item.moTa,item.SoLuongTon,item.giaBan,item.giaNhap,item.TrangThai
                    );
                    
            }
            foreach (var item in _IAnhservice.GetAll())
            {
                CB_Anh.Items.Add(item.Ma);
            }
            CB_Anh.SelectedIndex= 0;
        }
        public void loadanh()
        {
            PCB_ANH.Image = Image.FromFile(_IAnhservice.GetAll().FirstOrDefault(c => c.Ma == CB_Anh.Text).Link);
           
        }

        private void CB_Anh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadanh();
        }
    }
}
