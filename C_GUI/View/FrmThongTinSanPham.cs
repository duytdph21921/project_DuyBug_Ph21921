
﻿using B_BUS.IService;
using B_BUS.Service;
using B_BUS.ViewModel;
using System;
﻿using System;
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
        ISanPhamService _IsanphamService;
        Guid _IDChung;
        // tạo số khung số máy 
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";
        //
        List<ChiTietXeViewModel> _LstchiTietXeServices;
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
            _IsanphamService = new SanPhamService();
            _LstchiTietXeServices=  new List<ChiTietXeViewModel>();
            load();
            loadanh();
        }
        #region lấy mã ngẫu nhiên test
        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers,
            int passwordSize)
        {
            char[] _password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();
            int counter;


            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CASE;

            if (useNumbers) charSet += NUMBERS;

        //    if (useSpecial) charSet += SPECIALS;

            for (counter = 0; counter < passwordSize; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }

            return string.Join(null, _password);
        }
        private void BTN_SoKhung_Click(object sender, EventArgs e)
        {
            var passwordRandom = GeneratePassword(checkBox4.Checked, checkBox5.Checked, checkBox6.Checked,10);
            TB_SoKhung.Text = passwordRandom;
        }
        private void BTN_SoMay_Click(object sender, EventArgs e)
        {
            var passwordRandom = GeneratePassword(checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, 10);
            TB_SoMay.Text = passwordRandom;
        }
        //
        #endregion
        public void load()
        {
            // chọn mã chưa hiểu lên để đây
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            // chọn mã chưa hiểu
            dtg_sanpham.ColumnCount = 18;
            dtg_sanpham.Rows.Clear();
            dtg_sanpham.Columns[0].Name = "id";
            dtg_sanpham.Columns[1].Name = "Sản Phẩm";
          
            dtg_sanpham.Columns[2].Name = "Nhà Sản Xuất";
            dtg_sanpham.Columns[3].Name = "Loại Xe";
            dtg_sanpham.Columns[4].Name = "Màu";
            dtg_sanpham.Columns[5].Name = "Số Lượng";
            dtg_sanpham.Columns[6].Name = "Giá Bán";
            dtg_sanpham.Columns[7].Name = "Ngày Nhập";
            dtg_sanpham.Columns[8].Name = "Năm Bảo Hành";
            dtg_sanpham.Columns[9].Name = "Số khung";
            dtg_sanpham.Columns[10].Name = "Số Máy";
            dtg_sanpham.Columns[11].Name = "Dung Tích Bình Xăng";
            dtg_sanpham.Columns[12].Name = "Mô Tả";
          
            dtg_sanpham.Columns[13].Name = "Động Cơ";
            dtg_sanpham.Columns[14].Name = "Khởi Động";
            dtg_sanpham.Columns[15].Name = "Giá Nhập";
            dtg_sanpham.Columns[16].Name = "Trạng Thái";
            dtg_sanpham.Columns[17].Name = " Mã ảnh";
            dtg_sanpham.Columns[0].Visible = false;
          _LstchiTietXeServices = _IChiTietXeService.Getall();
 
            if (CCB_DangBan.Checked == true)
            {
                _LstchiTietXeServices = _LstchiTietXeServices.Where(c=>c.HTTT.Contains("Đang Bán")).ToList();


            }
            if (CCB_ngungban.Checked == true)
            {
                _LstchiTietXeServices = _LstchiTietXeServices.Where(c => c.HTTT.Contains("Ngừng Bán")).ToList();

            }
            foreach (var item in _LstchiTietXeServices)
            {
                dtg_sanpham.Rows.Add(item.id, item.SanPham, item.NSX,
                    item.LoaiXe, item.MauSac, item.SoLuongTon, item.giaBan,
                   item.NgayNhap, item.namBh, item.soKhung, item.soMay,
                   item.binhXang, item.moTa, item.DongCo, item.KhoiDong, item.giaNhap, item.HTTT,item.linkAnh
                    );

            }
            foreach (var item in _IAnhservice.GetAll())
            {
                CB_Anh.Items.Add(item.Ma);
            }
            CB_Anh.SelectedIndex= 0;
            foreach (var item in _IMauSacService.GetAll())
            {
                CB_MauSac.Items.Add(item.Ma);
            }
            foreach (var item in _INsxService.GetAll())
            {
                CB_NSX.Items.Add(item.Ma);
            }
            foreach (var item in _IloaiXeService.GetAll())
            {
                CB_LoaiXe.Items.Add(item.Ma);
            }
            foreach (var item in _IDongcoService.Getall())
            {
                CB_DongCo.Items.Add(item.Ma);
            }
            foreach (var item in _IsanphamService.Getall())
            {
                CB_SanPham.Items.Add(item.Ma);
            }
            foreach (var item in _IkhoiDongService.GetAll())
            {
                CB_KhoiDong.Items.Add(item.Ma);
            }
        }
        public void loadanh()
        {
            PCB_ANH.Image = Image.FromFile(_IAnhservice.GetAll().FirstOrDefault(c => c.Ma == CB_Anh.Text).Link);
            LB_Anh.Text = _IAnhservice.GetAll().FirstOrDefault(c => c.Ma == CB_Anh.Text).Ten;
        }
       
        private void CB_Anh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadanh();

        }
        int trangthai;
        public ChiTietXeViewModel ChiTietXeViewModel()
        {
            if (rdb_dangban.Checked == true)
            {
                trangthai = 1;
            }
            else if (rdb_ngungban.Checked == true)
            {
                trangthai = 0;
            }
            ChiTietXeViewModel viewModel = new ChiTietXeViewModel()
            {
                mauSacID = _IMauSacService.GetAll().FirstOrDefault(c => c.Ma == CB_MauSac.Text).id,
                DongCoID = _IDongcoService.Getall().FirstOrDefault(c => c.Ma == CB_DongCo.Text).id,
                khoiDongID = _IkhoiDongService.GetAll().FirstOrDefault(c => c.Ma == CB_KhoiDong.Text).id,
                anhID = _IAnhservice.GetAll().FirstOrDefault(c => c.Ma == CB_Anh.Text).id,
                NSXID = _INsxService.GetAll().FirstOrDefault(c => c.Ma == CB_NSX.Text).id,
                SanPhamID = _IsanphamService.Getall().FirstOrDefault(c => c.Ma == CB_SanPham.Text).id,
                LoaiXeID = _IloaiXeService.GetAll().FirstOrDefault(c => c.Ma == CB_LoaiXe.Text).id,
                NgayNhap = DTP_TIme.Value,
                namBh = float.Parse(TB_NBH.Text),
                soKhung = TB_SoKhung.Text,
                soMay = TB_SoMay.Text,
                binhXang = TB_binhXang.Text,
                moTa = rtb_mota.Text,
                SoLuongTon = int.Parse(TB_SoLuong.Text),
                giaBan = decimal.Parse(TB_GiaBan.Text),
                giaNhap = decimal.Parse(TB_GiaNhap.Text),
                TrangThai = trangthai,

            };
            return viewModel;
        }
        public ChiTietXeViewModel suaXoaXe()
        {
            if (rdb_dangban.Checked == true)
            {
                trangthai = 1;
            }
            else if (rdb_ngungban.Checked == true)
            {
                trangthai = 0;
            }
            ChiTietXeViewModel viewModel = new ChiTietXeViewModel()
            {
                id = _IDChung,
                mauSacID = _IMauSacService.GetAll().FirstOrDefault(c => c.Ma == CB_MauSac.Text).id,
                DongCoID = _IDongcoService.Getall().FirstOrDefault(c => c.Ma == CB_DongCo.Text).id,
                khoiDongID = _IkhoiDongService.GetAll().FirstOrDefault(c => c.Ma == CB_KhoiDong.Text).id,
                anhID = _IAnhservice.GetAll().FirstOrDefault(c => c.Ma == CB_Anh.Text).id,
                NSXID = _INsxService.GetAll().FirstOrDefault(c => c.Ma == CB_NSX.Text).id,
                SanPhamID = _IsanphamService.Getall().FirstOrDefault(c => c.Ma == CB_SanPham.Text).id,
                LoaiXeID = _IloaiXeService.GetAll().FirstOrDefault(c => c.Ma == CB_LoaiXe.Text).id,
                NgayNhap = DTP_TIme.Value,
                namBh = float.Parse(TB_NBH.Text),
                soKhung = TB_SoKhung.Text,
                soMay = TB_SoMay.Text,
                binhXang = TB_binhXang.Text,
                moTa = rtb_mota.Text,
                SoLuongTon = int.Parse(TB_SoLuong.Text),
                giaBan = decimal.Parse(TB_GiaBan.Text),
                giaNhap = decimal.Parse(TB_GiaNhap.Text),
                TrangThai = trangthai,

            };
            return viewModel;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IChiTietXeService.add(ChiTietXeViewModel()));
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IChiTietXeService.update(suaXoaXe()));
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var sua = _IChiTietXeService.Getall().FirstOrDefault(c => c.id == _IDChung);

            sua.TrangThai = 0;
            MessageBox.Show(_IChiTietXeService.update(sua));
            load();
        }

        private void CCB_DangBan_CheckedChanged(object sender, EventArgs e)
        {
            if (CCB_DangBan.Checked==true)
            {
                CCB_ngungban.Checked = false;
            }
            load();
        }

        private void CCB_ngungban_CheckedChanged(object sender, EventArgs e)
        {
            if (CCB_ngungban.Checked== true)
            {
                CCB_DangBan.Checked = false;
            }
            load();
        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDChung = Guid.Parse(dtg_sanpham.CurrentRow.Cells[0].Value.ToString());
            CB_MauSac.Text = dtg_sanpham.CurrentRow.Cells[4].Value.ToString();
            CB_SanPham.Text = dtg_sanpham.CurrentRow.Cells[1].Value.ToString();
            CB_NSX.Text = dtg_sanpham.CurrentRow.Cells[2].Value.ToString();
            CB_LoaiXe.Text = dtg_sanpham.CurrentRow.Cells[3].Value.ToString();
            TB_SoLuong.Text = dtg_sanpham.CurrentRow.Cells[5].Value.ToString();
            TB_GiaBan.Text = dtg_sanpham.CurrentRow.Cells[6].Value.ToString();
            DTP_TIme.Text = dtg_sanpham.CurrentRow.Cells[7].Value.ToString();
            TB_NBH.Text = dtg_sanpham.CurrentRow.Cells[8].Value.ToString();
            TB_SoKhung.Text = dtg_sanpham.CurrentRow.Cells[9].Value.ToString();
            TB_SoMay.Text = dtg_sanpham.CurrentRow.Cells[10].Value.ToString();
            TB_binhXang.Text = dtg_sanpham.CurrentRow.Cells[11].Value.ToString();
            rtb_mota.Text = dtg_sanpham.CurrentRow.Cells[12].Value.ToString();
            CB_DongCo.Text = dtg_sanpham.CurrentRow.Cells[13].Value.ToString();
            CB_KhoiDong.Text = dtg_sanpham.CurrentRow.Cells[14].Value.ToString();
            TB_GiaNhap.Text = dtg_sanpham.CurrentRow.Cells[15].Value.ToString();
            if (dtg_sanpham.CurrentRow.Cells[16].Value.ToString() == "Đang Bán")
            {
                rdb_dangban.Checked = true;
            }
            else
            {
                rdb_ngungban.Checked = true;
            }
           CB_Anh.Text = dtg_sanpham.CurrentRow.Cells[17].Value.ToString();
        }
# region load label
        public void loadlbmausac()
        {
           LB_Mausac.Text = CB_MauSac.Text !=null ?  _IMauSacService.GetAll().FirstOrDefault(c => c.Ma == CB_MauSac.Text).Ten : null;
        }
        public void loadNsx()
        {
            LB_NSX.Text = CB_NSX.Text != null ? _INsxService.GetAll().FirstOrDefault(c => c.Ma == CB_NSX.Text).Ten : null;
        }
        public void loadKhoiDong()
        {
            LB_KhoiDong.Text = _IkhoiDongService.GetAll().FirstOrDefault(c => c.Ma == CB_KhoiDong.Text).Ten;
        }
        public void loaddongco()
        {
            LB_dongCo.Text = _IDongcoService.Getall().FirstOrDefault(c => c.Ma == CB_DongCo.Text).Ten;
        }
        public void loadloaixe()
        {
            LB_LoaiXe.Text = _IloaiXeService.GetAll().FirstOrDefault(c => c.Ma == CB_LoaiXe.Text).Ten;
        }
        public void loadsanpham()
        {
            LB_SanPham.Text = _IsanphamService.Getall().FirstOrDefault(c=>c.Ma == CB_SanPham.Text).Ten;
        }
        private void CB_MauSac_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlbmausac();
        }

        private void CB_NSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNsx();
        }

        private void CB_LoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadloaixe();
        }

        private void CB_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadsanpham();  
        }

        private void CB_DongCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddongco();
        }

        private void CB_KhoiDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadKhoiDong();
        }
        #endregion
    }
}
