using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Service
{
    public class ChuVuService : IChucVuService
    {
        IChuVu _IChucVuService;
        public ChuVuService()
        {
            _IChucVuService = new ChucVus();
        }
        public string add(ChuVuViewModel chuVuViewModel)
        {
            try
            {
                if (chuVuViewModel == null) return " thêm thất bại";

                ChucVu chucVu = new ChucVu()
                {
                      id = chuVuViewModel.id,
                    Ma = chuVuViewModel.Ma,
                    Ten = chuVuViewModel.Ten,
                };
                if (_IChucVuService.add(chucVu)) return "thêm thành công";
             
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " thêm thất bại trùng mã";

        }

        public string delete(ChuVuViewModel chuVuViewModel)
        {
            ChucVu chucVu = new ChucVu()
            {
                id = chuVuViewModel.id,
             
            };
            if (_IChucVuService.delete(chucVu)) return "xóa thành công";
            return " xóa thất bại";
        }

        public List<ChuVuViewModel> getall()
        {
            var hienthi = (from a in _IChucVuService.GetAll()
                          select new ChuVuViewModel() { 
                              id = a.id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                          }).ToList();
            return hienthi;
        }

        public string update(ChuVuViewModel chuVuViewModel)
        {
            ChucVu chucVu = new ChucVu()
            {
                id = chuVuViewModel.id,
                Ma = chuVuViewModel.Ma,
                Ten = chuVuViewModel.Ten,
            };
            if (_IChucVuService.update(chucVu)) return "sửa thành công";
            return " sửa thất bại";
        }
    }
}
