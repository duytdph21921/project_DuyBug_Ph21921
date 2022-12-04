using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace B_BUS.Service
{
    public class ChiTietXeService : IChiTietXeService
    {
        IChiTietXe _Iichitietxe;
        IAnh _IANH;
        IMauSac _IMauSac;
        ILoaiXe _IloaiXe;
        ISanPham _ISanPham;
        IDongCo _IDongCo;
        IkhoiDong _IKhoiDong;
        INSX _INsx;
        public ChiTietXeService()
        {
            _Iichitietxe = new ChiTietXes();
            _IANH = new Anhs();
            _IMauSac = new MauSacs();
            _IDongCo= new DongCos();
            _IKhoiDong = new KhoiDongs();
            _INsx = new NSXs();
            _IloaiXe = new LoaiXe();
            _ISanPham = new SanPhams();
        }
        public string add(ChiTietXeViewModel chiTietXeViewModel)
        {


            try
            {
                if (chiTietXeViewModel == null)
                    /* tham số truyền vào bị null  kết quả trả về theo variable string  */
                    return " thêm thất bại";
                ChiTietXe chiTietXe = new ChiTietXe()
                {
                   
                    mauSacID = chiTietXeViewModel.mauSacID,
                    NSXID = chiTietXeViewModel.NSXID,
                    LoaiXeID= chiTietXeViewModel.LoaiXeID,
                    SanPhamID = chiTietXeViewModel.SanPhamID,
                    DongCoID =chiTietXeViewModel.DongCoID,
                    anhID = chiTietXeViewModel.anhID,
                    khoiDongID = chiTietXeViewModel.khoiDongID,
                    NgayNhap = chiTietXeViewModel.NgayNhap,
                    namBh = chiTietXeViewModel.namBh,
                    soKhung =chiTietXeViewModel.soKhung,
                    soMay =chiTietXeViewModel.soMay,
                    binhXang =chiTietXeViewModel.binhXang,
                    moTa =chiTietXeViewModel.moTa,
                    SoLuongTon =chiTietXeViewModel.SoLuongTon,
                    giaBan =chiTietXeViewModel.giaBan,
                    giaNhap =chiTietXeViewModel.giaNhap,
                    TrangThai =chiTietXeViewModel.TrangThai,
                };
                if (_Iichitietxe.add(chiTietXe)) return "thêm thành công";
                
            }
            catch (Exception e)
            {
                return e.Message;
               
            }
            return "thêm thất bại";
        }

        public string delete(ChiTietXeViewModel chiTietXeViewModel)
        {
            try
            {
                if (chiTietXeViewModel == null) return " xóa thất bại";
                ChiTietXe chiTietXe = new ChiTietXe()
                {
                    id = chiTietXeViewModel.id,
                };
                if (_Iichitietxe.delete(chiTietXe)) return " xóa thành công";
               
            }
            catch (Exception e)
            {
                return e.Message; 
            }
            return "xóa thất bại";
        }

        public List<ChiTietXeViewModel> Getall()
        {
            var chitietxeHt = (from ctx in _Iichitietxe.GetAll()
                               join ms in _IMauSac.GetAll() on ctx.mauSacID equals ms.id
                               join nsx in _INsx.GetAll() on ctx.NSXID equals nsx.id
                               join lsx in _IloaiXe.GetAll() on ctx.LoaiXeID equals lsx.id
                               join sp in _ISanPham.getAll() on ctx.SanPhamID equals sp.id
                               join dc in _IDongCo.GetAll() on ctx.DongCoID equals dc.id
                               join kd in _IKhoiDong.getAll() on ctx.khoiDongID equals kd.id
                               join a in _IANH.GetAll() on ctx.anhID equals a.id
                               select new ChiTietXeViewModel()
                               {
                                   id = ctx.id,
                                   MauSac = ms.Ten,
                                   linkAnh = a.Link,
                                   NSX  = nsx.Ten,
                                   LoaiXe = lsx.Ten,
                                   SanPham = sp.Ten,
                                   DongCo = dc.Ten,
                                   KhoiDong = kd.Ten,
                                   NgayNhap = ctx.NgayNhap,
                                   namBh = ctx.namBh,
                                   soKhung = ctx.soKhung,
                                   soMay = ctx.soMay,
                                   moTa = ctx.moTa,
                                   SoLuongTon = ctx.SoLuongTon,
                                   giaBan = ctx.giaBan,
                                   giaNhap = ctx.giaNhap,
                                   HTTT = ctx.TrangThai == 1 ?"Đang Bán" : "Ngừng Bán" 
                               }

                            ).ToList();
            return chitietxeHt;
        }

        public string update(ChiTietXeViewModel chiTietXeViewModel)
        {
            try
            {
                if (chiTietXeViewModel == null)
                    /* tham số truyền vào bị null  kết quả trả về theo variable string  */
                    return " sửa thất bại";
                ChiTietXe chiTietXe = new ChiTietXe()
                {
                    id = chiTietXeViewModel.id,
                    mauSacID = chiTietXeViewModel.mauSacID,
                    NSXID = chiTietXeViewModel.NSXID,
                    LoaiXeID = chiTietXeViewModel.LoaiXeID,
                    SanPhamID = chiTietXeViewModel.SanPhamID,
                    DongCoID = chiTietXeViewModel.DongCoID,
                    anhID = chiTietXeViewModel.anhID,
                    khoiDongID = chiTietXeViewModel.khoiDongID,
                    NgayNhap = chiTietXeViewModel.NgayNhap,
                    namBh = chiTietXeViewModel.namBh,
                    soKhung = chiTietXeViewModel.soKhung,
                    soMay = chiTietXeViewModel.soMay,
                    binhXang = chiTietXeViewModel.binhXang,
                    moTa = chiTietXeViewModel.moTa,
                    SoLuongTon = chiTietXeViewModel.SoLuongTon,
                    giaBan = chiTietXeViewModel.giaBan,
                    giaNhap = chiTietXeViewModel.giaNhap,
                    TrangThai = chiTietXeViewModel.TrangThai,
                };
                if (_Iichitietxe.update(chiTietXe)) return "sửa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            return "sửa thất bại";
        }
    }
}
