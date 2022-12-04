using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class KhachHang
    {
        public Guid id { get; set; }
        public string? Ma { get; set; }
        public string? Ten{ get; set; }
        public string? TenDem { get; set; }
        public string? Ho { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? gioitinh { get; set; }
        public string? sdt { get; set; }
        public string ?DiaChi { get; set; }
        public string ?ThanhPho { get; set; }
        public string? QuocGia { get; set; }
        public int? trangthai { get; set; }

    }
}
