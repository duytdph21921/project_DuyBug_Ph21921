using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IHoaDonChiTiet
    {
        public bool add(HoaDonChitiet hoaDonChiTiet);
        public bool update(HoaDonChitiet hoaDonChiTiet);
        public bool delete(HoaDonChitiet hoaDonChiTiet);
        public List<HoaDonChitiet> GetAll();
        
    }
}
