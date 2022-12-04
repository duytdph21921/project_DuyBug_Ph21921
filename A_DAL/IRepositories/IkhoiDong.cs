using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IkhoiDong
    {
        public bool add(khoiDong khoiDong);
        public bool delete(khoiDong khoiDong);
        public bool update(khoiDong khoiDong);
        public List<khoiDong> getAll();
    }
}
