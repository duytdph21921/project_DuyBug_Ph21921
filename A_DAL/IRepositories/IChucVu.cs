using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IChuVu
    {
        public bool add(ChucVu chucVu);
        public bool delete(ChucVu chucVu);
        public bool update(ChucVu chucVu);
        public List<ChucVu> GetAll();
    }
}
