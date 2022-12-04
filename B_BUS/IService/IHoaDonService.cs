using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IHoaDonService
    {
        public string add(HoaDonViewModel hoaDonViewModel);
        public string update(HoaDonViewModel hoaDonViewModel);
        public string delete(HoaDonViewModel hoaDonViewModel);
        public List<HoaDonViewModel> GetALL();
    }
}
