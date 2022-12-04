using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IChiTietXe
    {
        public bool add(ChiTietXe chiTietXe);
        public bool update(ChiTietXe chiTietXe);
        public bool delete(ChiTietXe chiTietXe);
        public List<ChiTietXe> GetAll();
    }
}
