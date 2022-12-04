using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IService
{
    public interface IChucVuService
    {
        public string add(ChuVuViewModel chuVuViewModel);
        public string update(ChuVuViewModel chuVuViewModel);
        public string delete(ChuVuViewModel chuVuViewModel);
        public List<ChuVuViewModel> getall();
    }
}
