using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class ChiTietXe
    {
        // chi tiết xe
        public Guid id { get; set; }
        public Guid ? mauSacID { get; set; } // id màu sắc
        public Guid ?NSXID { get; set; }// id NSX
        public Guid? LoaiXeID { get; set; } // id loại
        public Guid? SanPhamID { get; set; } // id sản phẩm 
        public Guid? DongCoID { get; set; } // id động cơ
        public Guid ?anhID { get; set; } // id ảnh
        public Guid ?khoiDongID { get; set; } // Khởi động
        public DateTime ?NgayNhap { get; set; } = DateTime.Now; // thời gian hiện tại
        public float ?namBh { get; set; } // năm bảo hành
        public string ?soKhung { get; set; }
        public string ?soMay { get; set; }
        public string? binhXang { get; set; }
        public string ?moTa { get; set; }
        public decimal ?SoLuongTon { get; set; }
        public decimal ?giaBan { get; set; }
        public decimal ?giaNhap { get; set; }
        public int ?TrangThai { get; set; }
        public virtual mauSac? MauSac { get; set; }
        public virtual NSX? NSX { get; set; }
        public virtual loaiXe? LoaiXe { get; set; }
        public virtual sanPham? SanPham { get; set; }
        public virtual dongCo? DongCo { get; set; }
        public virtual Anh? Anh { get; set; }
        public virtual khoiDong? khoidong { get; set; }
    }
}
