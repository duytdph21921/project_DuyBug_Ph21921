using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IChiTietXeService
    {
        public string add(ChiTietXeViewModel chiTietXeViewModel);
        public string update(ChiTietXeViewModel chiTietXeViewModel);
        public string delete(ChiTietXeViewModel chiTietXeViewModel);
        public List<ChiTietXeViewModel> Getall();
    }
}
