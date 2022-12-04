using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class NhanVien
    {
        public Guid id { get; set; }

        public Guid? ChuVuId { get; set; }
        public Guid? GuiBcId { get; set; }
        public Guid? Anhid { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string? TenDem { get; set; }
        public string? Ho { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? sdt { get; set; }
        public string? DiaChi { get; set; }
        public string? MatKhau { get; set; }
        public int? gioitinh { get; set; }
        public int? Trangthai { get; set; }
        public virtual Anh? anh { get; set; }
        public virtual ChucVu? ChucVu { get; set; }
        public virtual NhanVien? Guibc { get; set; }
    }
}
