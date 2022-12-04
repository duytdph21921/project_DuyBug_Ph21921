using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface ILoaiXeService
    {
        public string add(LoaiXeViewModel loaiXeViewModel);
        public string update(LoaiXeViewModel loaiXeViewModel);
        public string delete(LoaiXeViewModel loaiXeViewModel);
        public List<LoaiXeViewModel> GetAll();
    }
}
