using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.DomaninClass
{
    public class XeMayDbConText : DbContext
    {
        public XeMayDbConText()
        {

        }
        public XeMayDbConText(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-399B81S\\SQLEXPRESS;Initial Catalog=QL_Duan1_QuanLyCuaHangBanXeMay;" +
                "Persist Security Info=True;User ID=PH22814;Password=123456"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
        //tạo dbet để hứng dữ liệu từ database
        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<ChiTietXe> ChiTietXes { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<dongCo> DongCos { get; set; }
        public virtual DbSet<HoaDonChitiet> HoaDonChitiets { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<khoiDong> KhoiDongs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<loaiXe> LoaiXes { get; set; }
        public virtual DbSet<mauSac> MauSacs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NSX> NSXes  { get; set; }
        public virtual DbSet<sanPham> SanPhams  { get; set; }
    }
}
