using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B_BUS.Service
{
    public class NsxService : INsxService
    {
        INSX _INsxService;
        public NsxService()
        {
            _INsxService = new NSXs();
        }
        public string add(NSXViewModel nSXViewModel)
        {
            try
            {
                if (nSXViewModel == null) return "thêm thất bại";
                NSX nsx = new NSX()
                {

                    Ma = nSXViewModel.Ma,
                    Ten = nSXViewModel.Ten,
                };
                if (_INsxService.add(nsx)) return " thêm thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " thêm thất bại";
        }

        public string delete(NSXViewModel nSXViewModel)
        {
            try
            {
                if (nSXViewModel == null) return "xóa thất bại";
                NSX nsx = new NSX()
                {
                    id = nSXViewModel.id,
                  
                };
                if (_INsxService.delete(nsx)) return " xóa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " xóa thất bại";
        }

        public List<NSXViewModel> GetAll()
        {
            var hienthi = (from n in _INsxService.GetAll()
                           select new NSXViewModel()
                           {
                               id = n.id,
                               Ma =n.Ma,
                               Ten=n.Ten,
                           }).ToList();
            return hienthi;
        }

        public string update(NSXViewModel nSXViewModel)
        {
            try
            {
                if (nSXViewModel == null) return "sửa thất bại";
                NSX nsx = new NSX()
                {
                    id = nSXViewModel.id,
                    Ma = nSXViewModel.Ma,
                    Ten =nSXViewModel.Ten,

                };
                if (_INsxService.update(nsx)) return " sửa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " sửa thất bại";
        }
    }
}
