using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.ViewModel
{
    public class HoaDonChiTietViewModel
    {
        public Guid? HoaDonId { get; set; }
        public Guid? ChiTietXeId { get; set; }
        public Guid? KhuyenMaiID { get; set; }
        public int? soLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? trangthai { get; set; }
        // hiển thị 
        public string MauSac { get; set; } // id màu sắc
        public string NSX { get; set; }// id NSX
        public string LoaiXe { get; set; } // id loại
        public string SanPham { get; set; } // id sản phẩm 
        public string DongCo { get; set; } // id động cơ
        public string LinkAnh { get; set; } // id ảnh
        public string KhoiDong { get; set; } // Khởi động
        //
        /// <summary>
        /// 
        /// </summary>
        //
        public float? namBh { get; set; } // năm bảo hành
        public string soKhung { get; set; }
        public string soMay { get; set; }
        public string binhXang { get; set; }
        public string moTa { get; set; }
        public decimal SoLuongTon { get; set; }
        public decimal giaBan { get; set; }
        public int TrangThai { get; set; }
    }
}
