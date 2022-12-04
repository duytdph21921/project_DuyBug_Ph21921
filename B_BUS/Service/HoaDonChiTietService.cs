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
    public class HoaDonChiTietService : IChiTietHoaDonService
    {
        IHoaDon _IHoaDonService;
        IChiTietXe _IChiTietXeService;
        IKhuyenMai _IkhuyenMaiService;
        IHoaDonChiTiet _IHoaDonChiTietService;

        public HoaDonChiTietService()
        {
            _IHoaDonService= new HoaDons();
            _IChiTietXeService = new ChiTietXes();
            _IkhuyenMaiService = new KhuyenMais();
            _IHoaDonChiTietService = new HoaDonChiTiets();
        }
    
        public string add(HoaDonChiTietViewModel hoaDonChiTietViewModel)
        {
            try
            {
                if (hoaDonChiTietViewModel == null) return " thêm thất bại";
                HoaDonChitiet hoaDonChitiet = new HoaDonChitiet()
                {
                    ChiTietXeId = hoaDonChiTietViewModel.ChiTietXeId,
                    HoaDonId = hoaDonChiTietViewModel.ChiTietXeId,
                    KhuyenMaiID = hoaDonChiTietViewModel.KhuyenMaiID,
                    soLuong = hoaDonChiTietViewModel.soLuong,
                    DonGia = hoaDonChiTietViewModel.DonGia,
                    ThanhTien = hoaDonChiTietViewModel.ThanhTien,
                    trangthai = hoaDonChiTietViewModel.trangthai
                
                };
                if (_IHoaDonChiTietService.add(hoaDonChitiet))
                    return " thêm thành công";
                
            }
            catch (Exception e)
            {

                return e.Message ;
            }
            return " thêm thất bại";
        }

   

        public string delete(HoaDonChiTietViewModel hoaDonChiTietViewModel)
        {
            try
            {
                if (hoaDonChiTietViewModel == null) return " xóa thất bại";
                HoaDonChitiet hoaDonChitiet = new HoaDonChitiet()
                {
                    ChiTietXeId = hoaDonChiTietViewModel.ChiTietXeId,
                    HoaDonId = hoaDonChiTietViewModel.ChiTietXeId,
                    KhuyenMaiID = hoaDonChiTietViewModel.KhuyenMaiID,
                    soLuong = hoaDonChiTietViewModel.soLuong,
                    DonGia = hoaDonChiTietViewModel.DonGia,
                    ThanhTien = hoaDonChiTietViewModel.ThanhTien,
                    trangthai = hoaDonChiTietViewModel.trangthai

                };
                if (_IHoaDonChiTietService.delete(hoaDonChitiet))
                    return " xóa thành công";

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " xóa thất bại";
        }

        public List<HoaDonChiTietViewModel> GetAll()
        {
            var hthdct = (from hdct in _IHoaDonChiTietService.GetAll()
                          join HD in _IHoaDonService.GetAll() on hdct.HoaDonId equals HD.Id
                          join Ctx in _IChiTietXeService.GetAll() on hdct.ChiTietXeId equals Ctx.id
                          join km in _IkhuyenMaiService.GetAll() on hdct.KhuyenMaiID equals km.id
                          select new HoaDonChiTietViewModel()
                          {
                              /*HoaDonId= HD.Id,
                              ChiTietXeId= Ctx.id,
                              KhuyenMaiID = km.id,*/
                            // muốn hiển thị cái gì tự gõ ra 
                            // nhiều quá k biết 
                          }

                                ).ToList();
            return hthdct;
        }

        public string update(HoaDonChiTietViewModel hoaDonChiTietViewModel)
        {
            try
            {
                if (hoaDonChiTietViewModel == null) return " sửa thất bại";
                HoaDonChitiet hoaDonChitiet = new HoaDonChitiet()
                {
                    ChiTietXeId = hoaDonChiTietViewModel.ChiTietXeId,
                    HoaDonId = hoaDonChiTietViewModel.ChiTietXeId,
                    KhuyenMaiID = hoaDonChiTietViewModel.KhuyenMaiID,
                    soLuong = hoaDonChiTietViewModel.soLuong,
                    DonGia = hoaDonChiTietViewModel.DonGia,
                    ThanhTien = hoaDonChiTietViewModel.ThanhTien,
                    trangthai = hoaDonChiTietViewModel.trangthai

                };
                if (_IHoaDonChiTietService.update(hoaDonChitiet))
                    return " sửa thành công";

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " sửa thất bại";
        }

        

       
    }
}
