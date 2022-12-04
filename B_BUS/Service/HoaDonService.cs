using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace B_BUS.Service
{
    public class HoaDonService : IHoaDonService
    {
        IHoaDon _IHoaDon;
        IKhachHang _IKhachHang;
        INhavien _INhanVien;
        public HoaDonService()
        {
            _IHoaDon = new HoaDons();
            _IKhachHang = new KhachHangs();
            _INhanVien = new NhanViens();
        }
        public string add(HoaDonViewModel hoaDonViewModel)
        {
            try
            {
                if (hoaDonViewModel == null) return "thêm thất bại";
                HoaDon hoaDon = new HoaDon()
                {
                  //  Id = hoaDonViewModel.Id,
                    khachHangID = hoaDonViewModel.khachHangID,
                    nhanVienID =hoaDonViewModel.nhanVienID,
                    MA = hoaDonViewModel.MA,
                    ngayTao =hoaDonViewModel.ngayTao,
                    ngayThanhToan = hoaDonViewModel.ngayThanhToan,
                    NgayShip = hoaDonViewModel.NgayShip,
                    NgayNhan = hoaDonViewModel.NgayNhan,
                    NgayMongMuon = hoaDonViewModel.NgayMongMuon,
                    TenNguoiNhan =hoaDonViewModel.TenNguoiNhan,
                    SDT = hoaDonViewModel.SDT,
                    DiaChi =hoaDonViewModel.DiaChi,
                    trangthai =hoaDonViewModel.trangthai,

                };
                if (_IHoaDon.add(hoaDon)) return " thêm thành công";
              
            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " thêm thất bại";
          
    }

        public string delete(HoaDonViewModel hoaDonViewModel)
        {
            try
            {
                if (hoaDonViewModel == null) return "xóa thất bại";
                HoaDon hoaDon = new HoaDon()
                {
                    Id = hoaDonViewModel.Id,
                   

                };
                if (_IHoaDon.delete(hoaDon)) return " xóa thành công";

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " xóa thất bại";
        }

        public List<HoaDonViewModel> GetALL()
        {
            var hienthi = (from hd in _IHoaDon.GetAll()
                          join kh in _IKhachHang.GetALL() on hd.khachHangID equals kh.id
                          join nv in _INhanVien.getAll() on hd.nhanVienID equals nv.id
                          select new HoaDonViewModel()
                          {
                                MA = hd.MA,
                                MaNV = nv.Ma,
                                MaKH =kh.Ma,
                                ngayTao = hd.ngayTao,
                                HTTT = hd.trangthai ==1 ? "Đã Thanh Toán" :"CHưa Thanh Toán",
                          }).ToList();
            return hienthi;
        }

        public string update(HoaDonViewModel hoaDonViewModel)
        {
            try
            {
                if (hoaDonViewModel == null) return "sửa thất bại";
                HoaDon hoaDon = new HoaDon()
                {
                    Id = hoaDonViewModel.Id,
                    khachHangID = hoaDonViewModel.khachHangID,
                    nhanVienID = hoaDonViewModel.nhanVienID,
                    MA = hoaDonViewModel.MA,
                    ngayTao = hoaDonViewModel.ngayTao,
                    ngayThanhToan = hoaDonViewModel.ngayThanhToan,
                    NgayShip = hoaDonViewModel.NgayShip,
                    NgayNhan = hoaDonViewModel.NgayNhan,
                    NgayMongMuon = hoaDonViewModel.NgayMongMuon,
                    TenNguoiNhan = hoaDonViewModel.TenNguoiNhan,
                    SDT = hoaDonViewModel.SDT,
                    DiaChi = hoaDonViewModel.DiaChi,
                    trangthai = hoaDonViewModel.trangthai,

                };
                if (_IHoaDon.update(hoaDon)) return " sửa thành công";

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " sửa thất bại";
        }
    }
}
