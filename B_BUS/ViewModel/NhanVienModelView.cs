using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModel
{
    public class NhanVienModelView
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
        // hiển thị ngoài
        public string? Hovaten { get; set; }
        public string? tenChuVu { get; set; }
        public string? nhanvienguibaocao { get; set; }
       public  string ? linkAnh { get; set; }
        public string? HTTT { get; set; } 
        public string ?NamNu { get;set; }
       
        
    }
}
