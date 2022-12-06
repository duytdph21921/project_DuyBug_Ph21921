
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
            dtg_sanpham.ColumnCount = 17;
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
            dtg_sanpham.Columns[0].Visible = false;
          _LstchiTietXeServices = _IChiTietXeService.Getall();
 
            if (radioButton1.Checked == true)
            {
                _LstchiTietXeServices = _LstchiTietXeServices.Where(c=>c.HTTT == "Đang Bán").ToList();


            }
            if (radioButton2.Checked == true)
            {
                _LstchiTietXeServices = _LstchiTietXeServices.Where(c => c.HTTT =="Ngừng Bán").ToList();

            }
            foreach (var item in _LstchiTietXeServices)
            {
                dtg_sanpham.Rows.Add(item.id, item.MauSac, item.NSX,
                    item.LoaiXe, item.SanPham, item.DongCo, item.KhoiDong,
                   item.NgayNhap, item.namBh, item.soKhung, item.soMay,
                   item.binhXang, item.moTa, item.SoLuongTon, item.giaBan, item.giaNhap, item.HTTT
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
        }

        private void CCB_ngungban_CheckedChanged(object sender, EventArgs e)
        {
            if (CCB_ngungban.Checked== true)
            {
                CCB_DangBan.Checked = false;
            }
        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _IDChung = Guid.Parse(dtg_sanpham.CurrentRow.Cells[0].Value.ToString());
           
           // PCB_ANH.Image = Image.FromFile(_IAnhservice.GetAll().FirstOrDefault(c => c.id == _IDChung).Link);
        }

      
    }
}
