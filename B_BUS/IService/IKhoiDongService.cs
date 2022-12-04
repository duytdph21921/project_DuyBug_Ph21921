using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IKhoiDongService
    {
        public string add(KhoiDongViewModel khoiDongViewModel);
        public string update(KhoiDongViewModel khoiDongViewModel);
        public string delete(KhoiDongViewModel khoiDongViewModel);
        public List<KhoiDongViewModel> GetAll();
    }
}
