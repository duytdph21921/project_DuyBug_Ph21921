using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class HoaDons : IHoaDon
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon == null) return false;

                _dbcontext.HoaDons.Add(hoaDon);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                //
                return false;
            }
        }

        public bool delete(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon.Id == null) return false;
                {
                 
                    _dbcontext.HoaDons.Remove(_dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id));
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }

        public List<HoaDon> GetAll()
        {
            return _dbcontext.HoaDons.ToList();
        }

        public bool update(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon.Id == null) return false;
                {
                   var hd = _dbcontext.HoaDons.FirstOrDefault(c => c.Id == hoaDon.Id);
                    hd.khachHangID = hoaDon.khachHangID;
                    hd.nhanVienID = hoaDon.nhanVienID;
                    hd.MA = hoaDon.MA;
                    hd.ngayTao =   hoaDon.ngayTao;
                    hd.ngayThanhToan = hoaDon.ngayThanhToan;
                    hd.NgayShip = hoaDon.NgayShip;
                    hd.NgayNhan= hoaDon.NgayNhan;
                    hd.NgayMongMuon = hoaDon.NgayMongMuon;
                    hd.TenNguoiNhan = hoaDon.TenNguoiNhan;
                    hd.SDT =hoaDon.SDT;
                    hd.DiaChi = hoaDon.DiaChi;
                    hd.trangthai = hoaDon.trangthai;
                    _dbcontext.HoaDons.Update(hd);
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }
    }
}
