using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid? khachHangID { get; set; } // khách hàng
        public Guid ?nhanVienID { get; set; } // nhân viên
        public string? MA { get; set; }   // mã
        public DateTime ?ngayTao { get; set; } = DateTime.Now;// ngày tạo 
        public DateTime ?ngayThanhToan { get; set; } = DateTime.Now;
        public DateTime ?NgayShip { get; set; } 
        public DateTime ?NgayNhan { get; set; }
        public DateTime ?NgayMongMuon { get; set; }
        public string ?TenNguoiNhan { get; set; }
        public string ?SDT { get; set; }
        public string ?DiaChi { get;set; }
        public int ?trangthai { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
