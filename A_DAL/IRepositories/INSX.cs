using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface INSX
    {
        public bool add(NSX nSX);
        public bool delete(NSX nSX);
        public bool update(NSX nSX);
        public List<NSX> GetAll();
    }
}
