using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IKhachHang
    {
        public bool add(KhachHang khachHang);
        public bool update(KhachHang khachHang);
        public bool delete(KhachHang khachHang);
        public List<KhachHang> GetALL();
    }
}
