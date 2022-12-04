using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IHoaDon
    {
        public bool add(HoaDon hoaDon);
        public bool update(HoaDon hoaDon);
        public bool delete(HoaDon hoaDon);
        public List<HoaDon> GetAll(); 
    }
}
