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
    public class MauSacService : IMauSacService
    {
        IMauSac _IMauSac;
        public MauSacService()
        {
            _IMauSac = new MauSacs();
        }
        public string add(MauSacViewModel mauSacViewModel)
        {
            try
            {
                if (mauSacViewModel == null) return "thêm thất bại";
                mauSac mauSac = new mauSac()
                {
                  
                    Ma = mauSacViewModel.Ma,
                    Ten = mauSacViewModel.Ten,
                };
                if (_IMauSac.add(mauSac)) return " thêm thành công";
              
               
            }
            catch (Exception e)
            {

              return e.Message;
            }
            return " thêm thất bại";
        }

        public string delete(MauSacViewModel mauSacViewModel)
        {
            try
            {
                if (mauSacViewModel == null) return "xóa thất bại";
                mauSac mauSac = new mauSac()
                {

                   id = mauSacViewModel.id
                };
                if (_IMauSac.delete(mauSac)) return " xóa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " xóa thất bại";
        }

        public List<MauSacViewModel> GetAll()
        {
          var hienthi = (from a in _IMauSac.GetAll()
                         select new MauSacViewModel()
                         {
                             id = a.id,
                             Ma = a.Ma,
                             Ten = a.Ten,
                         }).ToList();
            return hienthi;
        }

        public string update(MauSacViewModel mauSacViewModel)
        {
            try
            {
                if (mauSacViewModel == null) return "thêm thất bại";
                mauSac mauSac = new mauSac()
                {
                    id= mauSacViewModel.id,
                    Ma = mauSacViewModel.Ma,
                    Ten = mauSacViewModel.Ten,
                };
                if (_IMauSac.update(mauSac)) return " sửa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " sửa thất bại";
        }
    }
}
