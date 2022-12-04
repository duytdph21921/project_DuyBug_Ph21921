using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IKhuyenMaiService
    {
        public string add(KhuyenMaiViewModel khuyenMaiViewModel);
        public string update(KhuyenMaiViewModel khuyenMaiViewModel);
        public string delete(KhuyenMaiViewModel khuyenMaiViewModel);
        public List<KhuyenMaiViewModel> getall();
    }
}
