using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface INhavien
    {
        public bool add(NhanVien nhanVien);
        public bool update(NhanVien nhanVien);
        public bool delete(NhanVien nhanVien);
        public List<NhanVien> getAll();
    }
}
