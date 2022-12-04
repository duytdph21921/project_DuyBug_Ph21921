using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class HoaDonChitiet
    {
        public Guid? HoaDonId { get; set; }
        public Guid? ChiTietXeId { get; set; }
        public Guid ?KhuyenMaiID { get; set; }
        public int ?soLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal ?ThanhTien { get; set; }
        public int ?trangthai { get;set; }
        public virtual HoaDon? HoaDon { get; set; }
        public virtual ChiTietXe? ChiTietXe { get; set; }
        public virtual KhuyenMai? KhuyenMai { get; set; }
    }
}
