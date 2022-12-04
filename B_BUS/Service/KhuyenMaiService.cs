using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B_BUS.Service
{
    public class KhuyenMaiService : IKhuyenMaiService
    {
        IKhuyenMai _IkhuyenMai;
        public KhuyenMaiService()
        {
            _IkhuyenMai= new KhuyenMais();
        }
        public string add(KhuyenMaiViewModel khuyenMaiViewModel)
        {
            try
            {
                if (khuyenMaiViewModel == null) return " thêm thất bại";
                KhuyenMai khuyenMai = new KhuyenMai()
                {
                    id = khuyenMaiViewModel.id,
                    Ma = khuyenMaiViewModel.Ma,
                    Ten = khuyenMaiViewModel.Ten,
                    mota = khuyenMaiViewModel.mota,
                    ngayTao = khuyenMaiViewModel.ngayTao,
                    NgayketThuc = khuyenMaiViewModel.NgayketThuc,
                    SoLuongGiam = khuyenMaiViewModel.SoLuongGiam,
                    TrangThai = khuyenMaiViewModel.TrangThai,
                };
                if (_IkhuyenMai.add(khuyenMai)) return " thêm thành công";
           
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return "thêm thất bại";
        }

        public List<KhuyenMaiViewModel> getall()
        {
            var hienthi = (from a in _IkhuyenMai.GetAll()
                           select new KhuyenMaiViewModel()
                           {
                               id = a.id,
                               Ma = a.Ma,
                               Ten = a.Ten,
                               mota = a.mota,
                               ngayTao= a.ngayTao,
                               NgayketThuc= a.NgayketThuc,
                               HTTT = a.TrangThai ==1 ? " Đang diễn ra" : "Kết thúc"
                           }).ToList();
            return hienthi;
        }

        public string delete(KhuyenMaiViewModel khuyenMaiViewModel)
        {
            try
            {
                if (khuyenMaiViewModel == null) return " xóa thất bại";
                KhuyenMai khuyenMai = new KhuyenMai()
                {
                    id = khuyenMaiViewModel.id,
                
                };
                if (_IkhuyenMai.delete(khuyenMai)) return " xóa thành công";

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return "xóa thất bại";
        }

        public string update(KhuyenMaiViewModel khuyenMaiViewModel)
        {
            try
            {
                if (khuyenMaiViewModel == null) return " sửa thất bại";
                KhuyenMai khuyenMai = new KhuyenMai()
                {
                    id = khuyenMaiViewModel.id,
                    Ma = khuyenMaiViewModel.Ma,
                    Ten = khuyenMaiViewModel.Ten,
                    mota = khuyenMaiViewModel.mota,
                    ngayTao = khuyenMaiViewModel.ngayTao,
                    NgayketThuc = khuyenMaiViewModel.NgayketThuc,
                    SoLuongGiam = khuyenMaiViewModel.SoLuongGiam,
                    TrangThai = khuyenMaiViewModel.TrangThai,
                };
                if (_IkhuyenMai.update(khuyenMai)) return " sửa thành công";

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return "sửa thất bại";
        }
    }
}
