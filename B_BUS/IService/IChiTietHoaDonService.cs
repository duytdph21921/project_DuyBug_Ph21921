using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IChiTietHoaDonService
    {
        public string add(HoaDonChiTietViewModel hoaDonChiTietViewModel);
        public string update(HoaDonChiTietViewModel hoaDonChiTietViewModel);
        public string delete(HoaDonChiTietViewModel hoaDonChiTietViewModel);
        public List<HoaDonChiTietViewModel> GetAll();
    }
}
