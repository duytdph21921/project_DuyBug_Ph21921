using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhanViens : INhavien
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            _dbcontext.NhanViens.Add(nhanVien);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool delete(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var nv = _dbcontext.NhanViens.FirstOrDefault(c => c.id == nhanVien.id);
            _dbcontext.NhanViens.Remove(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> getAll()
        {
            
            return _dbcontext.NhanViens.ToList();
        }

        public bool update(NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            var nv = _dbcontext.NhanViens.FirstOrDefault(c => c.id == nhanVien.id);
            nv.Ma = nhanVien.Ma;
            nv.Ten= nhanVien.Ten;
            nv.Ho= nhanVien.Ho;
            nv.TenDem= nhanVien.TenDem;
            nv.NgaySinh= nhanVien.NgaySinh;
            nv.sdt= nhanVien.sdt;
            nv.DiaChi= nhanVien.DiaChi;
            nv.MatKhau= nhanVien.MatKhau;
            nv.gioitinh= nhanVien.gioitinh;
            nv.Trangthai= nhanVien.Trangthai;
            _dbcontext.NhanViens.Update(nv);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
