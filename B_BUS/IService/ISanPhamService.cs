using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface ISanPhamService
    {
        public string add(SanPhamViewModel sanPhamViewModel);
        public string update(SanPhamViewModel sanPhamViewModel);
        public string delete(SanPhamViewModel sanPhamViewModel);
        public List<SanPhamViewModel> Getall();
    }
}
