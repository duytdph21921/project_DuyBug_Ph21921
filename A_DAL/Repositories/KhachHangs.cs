using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A_DAL.Repositories
{
    public class KhachHangs : IKhachHang
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(KhachHang khachHang)
        {
            try
            {
                if (khachHang == null) return false;
                _dbcontext.KhachHangs.Add(khachHang);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(KhachHang khachHang)
        {
            try
            {
                if (khachHang.id == null) return false;
                var kh = _dbcontext.KhachHangs.FirstOrDefault(c => c.id == khachHang.id);
                _dbcontext.KhachHangs.Remove(kh);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool update(KhachHang khachHang)
        {
            try
            {
                if (khachHang.id == null) return false;
                var kh = _dbcontext.KhachHangs.FirstOrDefault(c => c.id == khachHang.id);
                kh.Ma = khachHang.Ma;
                kh.Ten = khachHang.Ten;
                kh.TenDem = khachHang.TenDem;
                kh.Ho = khachHang.Ho;
                kh.NgaySinh = khachHang.NgaySinh;
                kh.sdt = khachHang.sdt;
                kh.DiaChi = khachHang.DiaChi;
                kh.ThanhPho = khachHang.ThanhPho;
                kh.QuocGia = khachHang.QuocGia;
                kh.trangthai = khachHang.trangthai;
                kh.gioitinh = khachHang.gioitinh;

                _dbcontext.KhachHangs.Update(kh);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<KhachHang> GetALL()
        {
            return _dbcontext.KhachHangs.ToList();
        }

      

    }
}
