using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace B_BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHang _IKhachHang;
       
        public KhachHangService()
        {
            _IKhachHang = new KhachHangs();
           
        }
        public string add(KhachHangViewModel khachHangViewModel)
        {
            try
            {
                if (khachHangViewModel == null) return "thêm thất bại";
                KhachHang khachHang = new KhachHang()
                {
                   id = khachHangViewModel.id,
                   Ma  = khachHangViewModel.Ma,
                   Ten = khachHangViewModel.Ten,
                   TenDem = khachHangViewModel.TenDem,
                   Ho = khachHangViewModel.Ho,
                   NgaySinh = khachHangViewModel.NgaySinh,
                    gioitinh = khachHangViewModel.gioitinh,
                    sdt = khachHangViewModel.sdt,
                   DiaChi = khachHangViewModel.DiaChi,
                   ThanhPho = khachHangViewModel.ThanhPho,
                   QuocGia = khachHangViewModel.QuocGia,
                   trangthai = khachHangViewModel.trangthai

                };
                if (_IKhachHang.add(khachHang)) return " thêm thành công";

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " thêm thất bại";

        }

        public string delete(KhachHangViewModel khachHangViewModel)
        {
            try
            {
                if (khachHangViewModel == null) return "xóa thất bại";
                KhachHang khachHang = new KhachHang()
                {
                    id = khachHangViewModel.id,
                  

                };
                if (_IKhachHang.delete(khachHang)) return " xóa thành công";

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " xóa thất bại";
        }

        public List<KhachHangViewModel> GetAll()
        {
            var Hienthi = (from kh in _IKhachHang.GetALL() 
                          select new KhachHangViewModel ()
                          {
                              id  = kh.id,
                              Ma = kh.Ma,
                              HoVaTen = kh.Ho + " " + kh.TenDem + " " + kh.Ten,
                              NgaySinh = kh.NgaySinh,
                              sdt = kh.sdt,
                              DiaChi = kh.DiaChi +" "+ kh.ThanhPho + " " +kh.QuocGia,
                              HTTT = kh.trangthai == 1 ?" Đang Hoạt Động" : " Ngừng Hoạt Động",
                              NamNu =kh.gioitinh ==1? "Nam":"Nữ"

                          }).ToList();
                          return Hienthi; 
        }

        public string update(KhachHangViewModel khachHangViewModel)
        {
            try
            {
                if (khachHangViewModel == null) return "sửa thất bại";
                KhachHang khachHang = new KhachHang()
                {
                    id = khachHangViewModel.id,
                    Ma = khachHangViewModel.Ma,
                    Ten = khachHangViewModel.Ten,
                    TenDem = khachHangViewModel.TenDem,
                    Ho = khachHangViewModel.Ho,
                    NgaySinh = khachHangViewModel.NgaySinh,
                    gioitinh= khachHangViewModel.gioitinh,
                    sdt = khachHangViewModel.sdt,
                    DiaChi = khachHangViewModel.DiaChi,
                    ThanhPho = khachHangViewModel.ThanhPho,
                    QuocGia = khachHangViewModel.QuocGia,
                    trangthai = khachHangViewModel.trangthai

                };
                if (_IKhachHang.update(khachHang)) return " sửa thành công";

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return " sửa thất bại";
        }
    }
}
