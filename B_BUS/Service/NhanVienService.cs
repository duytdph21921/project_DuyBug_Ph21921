using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B_BUS.Service
{
    public class NhanVienService : INhanVienService
    {
        INhavien _INhanVien;
        IChuVu _ChuVu;
        IAnh _Anh;
        public NhanVienService()
        {
            _INhanVien = new NhanViens();
            _ChuVu = new ChucVus();
            _Anh = new Anhs();
        }
        public string add(NhanVienModelView nhanVienModelView)
        {
            NhanVien nhanVien = new NhanVien()
            {
                id = nhanVienModelView.id,
                ChuVuId = nhanVienModelView.ChuVuId,
                GuiBcId = nhanVienModelView.GuiBcId,
                Anhid = nhanVienModelView.Anhid,
                Ma = nhanVienModelView.Ma,
                Ten = nhanVienModelView.Ten,
                TenDem = nhanVienModelView.TenDem,
                Ho = nhanVienModelView.Ho,
                NgaySinh = nhanVienModelView.NgaySinh,
                sdt = nhanVienModelView.sdt,
                DiaChi = nhanVienModelView.DiaChi,
                MatKhau = nhanVienModelView.MatKhau,
                gioitinh = nhanVienModelView.gioitinh,
                Trangthai = nhanVienModelView.Trangthai,
            };
            if (_INhanVien.add(nhanVien)) return " thêm thành công";
           
            return "thêm không thành công";
        }

        public List<NhanVienModelView> GetAll()
        {
            var qlnhavien = (from nv in _INhanVien.getAll()
                             join cv in _ChuVu.GetAll() on nv.ChuVuId equals cv.id
                             join a in _Anh.GetAll() on nv.Anhid equals a.id

                             select new NhanVienModelView
                             {
                                 id = nv.id,
                                 Ma = nv.Ma,
                                 tenChuVu = nv.ChuVuId != null ? _ChuVu.GetAll().FirstOrDefault(c=>c.id == nv.ChuVuId).Ten.ToString() : null,
                                 nhanvienguibaocao = nv.GuiBcId != null ? _INhanVien.getAll().FirstOrDefault(c=>c.id == nv.GuiBcId).Ten.ToString() : null,
                                 linkAnh = nv.Anhid != null ? _Anh.GetAll().FirstOrDefault(c=>c.id == nv.Anhid).Link.ToString() :null,
                                 Hovaten = nv.Ho + nv.TenDem + nv.Ten,
                                 NgaySinh = nv.NgaySinh,
                                 sdt= nv.sdt,
                                 DiaChi = nv.DiaChi,
                                 MatKhau = nv.MatKhau,
                                 NamNu = nv.gioitinh == 1?"Nam" : "Nữ",
                                 HTTT = nv.Trangthai == 1?"Đang làm việc" : "Nghỉ Việc",
                             }).ToList();
            return qlnhavien;
        }

        public string remove(NhanVienModelView nhanVienModelView)
        {

            NhanVien nhanVien = new NhanVien()
            {
                id = nhanVienModelView.id,
              
            };
            if (_INhanVien.delete(nhanVien)) return " xóa thành công";

            return "xóa không thành công";
        }

        public string update(NhanVienModelView nhanVienModelView)
        {

            NhanVien nhanVien = new NhanVien()
            {
                id = nhanVienModelView.id,
                ChuVuId = nhanVienModelView.ChuVuId,
                GuiBcId = nhanVienModelView.GuiBcId,
                Anhid = nhanVienModelView.Anhid,
                Ma = nhanVienModelView.Ma,
                Ten = nhanVienModelView.Ten,
                TenDem = nhanVienModelView.TenDem,
                Ho = nhanVienModelView.Ho,
                NgaySinh = nhanVienModelView.NgaySinh,
                sdt = nhanVienModelView.sdt,
                DiaChi = nhanVienModelView.DiaChi,
                MatKhau = nhanVienModelView.MatKhau,
                gioitinh = nhanVienModelView.gioitinh,
                Trangthai = nhanVienModelView.Trangthai,
            };
            if (_INhanVien.update(nhanVien)) return " sửa thành công";

            return "sửa không thành công";
        }
    }
}
