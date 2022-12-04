using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace B_BUS.Service
{
    public class DongCoService : IDongCoService
    {
        IDongCo _IDongCoService;
        public DongCoService()
        {
            _IDongCoService= new DongCos();
        }
        public string add(DongCoviewmodel dongCoviewmodel)
        {
           
                if (dongCoviewmodel == null) return " thêm thất bại";
                dongCo dongCo = new dongCo()
                {

                    Ma = dongCoviewmodel.Ma,
                    Ten = dongCoviewmodel.Ten,
                };
                if (_IDongCoService.add(dongCo)) return " thêm thành công";
            return " thêm thành công";




        }

        public string delete(DongCoviewmodel dongCoviewmodel)
        {
            if (dongCoviewmodel == null) return " xóa thất bại";
                dongCo dongCo = new dongCo()
                {
                    id = dongCoviewmodel.id,
                    Ma= dongCoviewmodel.Ma,
                    Ten = dongCoviewmodel.Ten,
                
                };
                if (_IDongCoService.delete(dongCo)) return " xóa thành công";



            return " xóa thành công";
        }

        public List<DongCoviewmodel> Getall()
        {  
            var dongco = (from a in _IDongCoService.GetAll()
                          select new DongCoviewmodel()
                          {
                              id = a.id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                          }).ToList();
            return  dongco;
        }

        public string update(DongCoviewmodel dongCoviewmodel)
        {
            
                if (dongCoviewmodel == null) return " sửa thất bại";
                dongCo dongCo = new dongCo()
                {
                    id= dongCoviewmodel.id,
                    Ma = dongCoviewmodel.Ma,
                    Ten = dongCoviewmodel.Ten,
                };
                if (_IDongCoService.update(dongCo)) return " sửa thành công";


            return " sửa thành công";
        }
    }
}
