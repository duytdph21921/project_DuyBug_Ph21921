using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class KhuyenMai
    {
        public Guid id { get; set; }
        public string? Ma { get; set; }
        public string ?Ten { get; set; }
        public string ?mota { get; set; }
        public DateTime ?ngayTao { get; set; } = DateTime.Now;
        public DateTime ?NgayketThuc { get; set; }
        public float ?SoLuongGiam { get;set; }
        public int ?TrangThai { get; set; }
    }
}
