using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IKhachHangService
    {
        public string add(KhachHangViewModel khachHangViewModel);
        public string update(KhachHangViewModel khachHangViewModel);
        public string delete(KhachHangViewModel khachHangViewModel);
        public List<KhachHangViewModel> GetAll();
    }
}
