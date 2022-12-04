using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ISanPham
    {
        public bool add(sanPham sanPham);
        public bool update(sanPham sanPham);
        public bool delete(sanPham sanPham);
        public List<sanPham> getAll();
    }
}
