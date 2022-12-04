using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class KhuyenMais : IKhuyenMai
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai == null) return false;
                _dbcontext.KhuyenMais.Add(khuyenMai);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai.id == null) return false;
                var km = _dbcontext.KhuyenMais.FirstOrDefault(c => c.id == khuyenMai.id);
                _dbcontext.KhuyenMais.Remove(km);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<KhuyenMai> GetAll()
        {
            return _dbcontext.KhuyenMais.ToList();
        }

        public bool update(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai.id == null) return false;
                var km = _dbcontext.KhuyenMais.FirstOrDefault(c => c.id == khuyenMai.id);
                km.Ma = khuyenMai.Ma;
                km.Ten = khuyenMai.Ten;
                km.mota= khuyenMai.mota;
                km.NgayketThuc = khuyenMai.NgayketThuc;
                km.SoLuongGiam = khuyenMai.SoLuongGiam;
                km.TrangThai = khuyenMai.TrangThai;
                _dbcontext.KhuyenMais.Update(km);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
