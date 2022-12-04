using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.ViewModel
{
    public class KhuyenMaiViewModel
    {
        public Guid id { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string? mota { get; set; }
        public DateTime? ngayTao { get; set; } = DateTime.Now;
        public DateTime? NgayketThuc { get; set; }
        public float? SoLuongGiam { get; set; }
        public int? TrangThai { get; set; }
        // hiển thị
        public string HTTT { get; set; }
    }
}
