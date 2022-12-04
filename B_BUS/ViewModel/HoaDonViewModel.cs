using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.ViewModel
{
    public class HoaDonViewModel
    {
        public Guid Id { get; set; }
        public Guid? khachHangID { get; set; } // khách hàng
        public Guid? nhanVienID { get; set; } // nhân viên
      
       
        public DateTime? ngayThanhToan { get; set; } = DateTime.Now;
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayMongMuon { get; set; }
        public string? TenNguoiNhan { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
        public int? trangthai { get; set; }
        // hiển thị from stt , mahd ,manv,makh ,ngaytao,trangthai
        public string? MA { get; set; }   // mã
        public DateTime? ngayTao { get; set; } = DateTime.Now;// ngày tạo 
        public string? HTTT { get; set; }
        public string? MaNV { get; set; }
        public string? MaKH { get; set; }
        
    }
}
