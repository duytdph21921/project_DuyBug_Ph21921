using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IKhuyenMai
    {
        public bool add(KhuyenMai khuyenMai);
        public bool update(KhuyenMai khuyenMai);
        public bool delete(KhuyenMai khuyenMai);
        public List<KhuyenMai> GetAll();
    }
}
