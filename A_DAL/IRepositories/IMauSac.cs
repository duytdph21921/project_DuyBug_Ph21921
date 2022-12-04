using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IMauSac
    {
        public bool add(mauSac mauSac);
        public bool delete(mauSac mauSac);
        public bool update(mauSac mauSac);
        public List<mauSac> GetAll();
    }
}
