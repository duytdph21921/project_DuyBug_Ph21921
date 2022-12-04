using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace B_BUS.Service
{
    public class LoaiXeService : ILoaiXeService
    {
        ILoaiXe _IloaiXe;
        public LoaiXeService()
        {
            _IloaiXe = new LoaiXe();
        }
        public string add(LoaiXeViewModel loaiXeViewModel)
        {
            try
            {
                if (loaiXeViewModel == null) return " thêm thành công";
                loaiXe loaiXe = new loaiXe()
                {
                  
                    Ma = loaiXeViewModel.Ma,
                    Ten = loaiXeViewModel.Ten
                };
                if (_IloaiXe.add(loaiXe)) return " thêm thành công";
              
            }
            catch (Exception e)
            {
                return e.Message;
               
            }
            return " thêm thất bại";
        }

        public string delete(LoaiXeViewModel loaiXeViewModel)
        {
            try
            {
                if (loaiXeViewModel == null) return " xóa thành công";
                loaiXe loaiXe = new loaiXe()
                {

                   id= loaiXeViewModel.id,
                };
                if (_IloaiXe.delete(loaiXe)) return " xóa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            return " xóa thất bại";
        }

        public List<LoaiXeViewModel> GetAll()
        {
            var hienthi = (from a in _IloaiXe.GetAll()
                           select new LoaiXeViewModel()
                           {
                               id = a.id,
                               Ma = a.Ma,
                               Ten = a.Ten,
                           }).ToList();
            return hienthi;
        }

        public string update(LoaiXeViewModel loaiXeViewModel)
        {
            try
            {
                if (loaiXeViewModel == null) return " xóa thành công";
                loaiXe loaiXe = new loaiXe()
                {

                    id = loaiXeViewModel.id,
                    Ma = loaiXeViewModel.Ma,
                    Ten = loaiXeViewModel.Ten,
                };
                if (_IloaiXe.update(loaiXe)) return " xóa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            return " xóa thất bại";
        }
    }
}
