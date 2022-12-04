using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IAnh
    {
        public bool add(Anh anh);
        public bool  update(Anh anh);
        public bool delete(Anh anh);
        public List<Anh> GetAll();
    }
}
