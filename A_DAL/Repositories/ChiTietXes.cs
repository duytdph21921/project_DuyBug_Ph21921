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
    public class ChiTietXes :IChiTietXe
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();

        public bool add(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe == null) return false;
                
                    _dbcontext.ChiTietXes.Add(chiTietXe);
                    _dbcontext.SaveChanges();
                    return true;
             
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool delete(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe.id == null) return false;
                var ctx = _dbcontext.ChiTietXes.FirstOrDefault(c => c.id == chiTietXe.id);
                _dbcontext.ChiTietXes.Remove(ctx);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ChiTietXe> GetAll()
        {
            return _dbcontext.ChiTietXes.ToList();
        }

        public bool update(ChiTietXe chiTietXe)
        {
            try
            {
                if (chiTietXe.id == null) return false;
                var ctx = _dbcontext.ChiTietXes.FirstOrDefault(c => c.id == chiTietXe.id);
                ctx.SanPhamID = chiTietXe.SanPhamID;
                ctx.NSXID = chiTietXe.NSXID;
                ctx.LoaiXeID = chiTietXe.LoaiXeID;
                ctx.mauSacID = chiTietXe.mauSacID;
                ctx.DongCoID = chiTietXe.DongCoID;
                ctx.khoiDongID = chiTietXe.khoiDongID;
                ctx.anhID = chiTietXe.anhID;
                ctx.NgayNhap = chiTietXe.NgayNhap;
                ctx.namBh =chiTietXe.namBh;
                ctx.soKhung = chiTietXe.soKhung;
                ctx.soMay = chiTietXe.soMay;
                ctx.binhXang = chiTietXe.binhXang;
                ctx.moTa = chiTietXe.moTa;
                ctx.SoLuongTon = chiTietXe.SoLuongTon;
                ctx.giaBan = chiTietXe.giaBan;
                ctx.giaNhap = chiTietXe.giaNhap;
                ctx.TrangThai = chiTietXe.TrangThai;
                _dbcontext.ChiTietXes.Update(ctx);
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
