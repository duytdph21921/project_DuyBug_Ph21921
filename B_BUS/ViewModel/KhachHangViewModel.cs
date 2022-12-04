using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.ViewModel
{
    public class KhachHangViewModel
    {
        public Guid id { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string? TenDem { get; set; }
        public string? Ho { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? sdt { get; set; }
       public int ? gioitinh { get; set; }
        public string? ThanhPho { get; set; }
        public string? QuocGia { get; set; }
        public int? trangthai { get; set; }
        // hiển thị from
        public string HTTT { get; set; }
        public string HoVaTen { get; set; }
        public string? DiaChi { get; set; }
        public string? NamNu {get; set; }

    }
}
