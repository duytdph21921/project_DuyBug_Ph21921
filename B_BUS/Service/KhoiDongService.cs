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
    public class KhoiDongService : IKhoiDongService
    {
        IkhoiDong _IkhoiDong;
        public KhoiDongService()
        {
            _IkhoiDong = new KhoiDongs();
        }
        public string add(KhoiDongViewModel khoiDongViewModel)
        {
            try
            {
                if (khoiDongViewModel == null) return " thêm thất bại";
                khoiDong khoiDong = new khoiDong()
                {

                    Ma = khoiDongViewModel.Ma,
                    Ten = khoiDongViewModel.Ten,
                };
                if (_IkhoiDong.add(khoiDong)) return " thêm thành công";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return " thêm thất bại";
        }
        public string delete(KhoiDongViewModel khoiDongViewModel)
        {
            try
            {
                if (khoiDongViewModel == null) return " xóa thất bại";
                khoiDong khoiDong = new khoiDong()
                {
                    id = khoiDongViewModel.id,
                  
                };
                if (_IkhoiDong.delete(khoiDong)) return " xóa thành công";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return " xóa thất bại";
        }

        public List<KhoiDongViewModel> GetAll()
        {
           var hienthi =( from a in _IkhoiDong.getAll()
                         select new KhoiDongViewModel()
                         {
                             id = a.id,
                             Ma = a.Ma,
                             Ten =a.Ten,
                         }).ToList();
            return hienthi;
        }

        public string update(KhoiDongViewModel khoiDongViewModel)
        {

            try
            {
                if (khoiDongViewModel == null) return " sửa thất bại";
                khoiDong khoiDong = new khoiDong()
                {
                    id = khoiDongViewModel.id,
                    Ma = khoiDongViewModel.Ma,
                    Ten = khoiDongViewModel.Ten,
                };
                if (_IkhoiDong.update(khoiDong)) return " sửa thành công";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return " sửa thất bại";
        }
    }
}
