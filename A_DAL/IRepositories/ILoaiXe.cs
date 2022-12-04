using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ILoaiXe
    {
        public bool add(loaiXe loaiXe);
        public bool delete(loaiXe loaiXe);
        public bool update(loaiXe loaiXe);
        public List<loaiXe> GetAll();
    }
}
