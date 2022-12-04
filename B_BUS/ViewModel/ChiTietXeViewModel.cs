using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.ViewModel
{
    public class ChiTietXeViewModel
    {
        // lưu vào csql 
        public Guid id { get; set; }
        public Guid? mauSacID { get; set; } 
        public Guid? NSXID { get; set; }
        public Guid? LoaiXeID { get; set; } 
        public Guid? SanPhamID { get; set; } 
        public Guid? DongCoID { get; set; } 
        public Guid? anhID { get; set; } 
        public Guid? khoiDongID { get; set; } 
        public DateTime? NgayNhap { get; set; } = DateTime.Now; 
        public float? namBh { get; set; } 
        public string? soKhung { get; set; }
        public string? soMay { get; set; }
        public string? binhXang { get; set; }
        public string? moTa { get; set; }
        public decimal? SoLuongTon { get; set; }
        public decimal? giaBan { get; set; }
        public decimal? giaNhap { get; set; }
        public int? TrangThai { get; set; }
        // hiển thị ra from 
        public string? MauSac { get; set; }
        public string? NSX { get; set; }
        public string? LoaiXe { get; set; }
        public string? SanPham { get; set; }
        public string? DongCo { get; set; }
        public string? linkAnh { get; set; }
        public string? KhoiDong { get; set; }
        public string? HTTT { get; set; }


    }
}
