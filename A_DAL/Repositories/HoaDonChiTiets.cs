using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class HoaDonChiTiets : IHoaDonChiTiet
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(HoaDonChitiet hoaDonChiTiet)
        {
            try
            {
                if (hoaDonChiTiet == null) return false;
                _dbcontext.Add(hoaDonChiTiet);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(HoaDonChitiet hoaDonChiTiet)
        {
            try
            {
                if (hoaDonChiTiet == null) return false;
                var hdct = _dbcontext.HoaDonChitiets.FirstOrDefault(c => c.HoaDonId == hoaDonChiTiet.HoaDonId);
                _dbcontext.HoaDonChitiets.Remove(hdct);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<HoaDonChitiet> GetAll()
        {
            return _dbcontext.HoaDonChitiets.ToList();
        }

        public bool update(HoaDonChitiet hoaDonChiTiet)
        {
            try
            {
                if (hoaDonChiTiet == null) return false;
                var hdct = _dbcontext.HoaDonChitiets.FirstOrDefault(c => c.HoaDonId == hoaDonChiTiet.HoaDonId);
                hdct.HoaDonId = hoaDonChiTiet.HoaDonId;
                hdct.KhuyenMaiID = hoaDonChiTiet.KhuyenMaiID;
                hdct.soLuong = hoaDonChiTiet.soLuong;
                hdct.DonGia = hoaDonChiTiet.DonGia;
                hdct.ThanhTien = hoaDonChiTiet.ThanhTien;
                hdct.trangthai = hoaDonChiTiet.trangthai;
                _dbcontext.HoaDonChitiets.Update(hdct);
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
