using A_DAL.DomaninClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
           builder.HasKey(x=>x.Id);
            builder.HasAlternateKey(x => x.MA);
            builder.Property(c => c.khachHangID).IsRequired();
            builder.Property(c => c.nhanVienID).IsRequired();
            builder.Property(c => c.MA).HasColumnType("varchar(100)");
            builder.Property(x => x.ngayTao).HasColumnType("datetime");
            builder.Property(x => x.ngayThanhToan).HasColumnType("datetime");
            builder.Property(x => x.NgayShip).HasColumnType("datetime");
            builder.Property(x => x.NgayNhan).HasColumnType("datetime");
            builder.Property(x => x.NgayMongMuon).HasColumnType("datetime");
            builder.Property(x => x.TenNguoiNhan).HasColumnType("Nvarchar(100)");
            builder.Property(x => x.SDT).HasColumnType("Nvarchar(100)");
            builder.Property(x => x.DiaChi).HasColumnType("Nvarchar(100)");
            builder.Property(x => x.trangthai).HasColumnType("int");
            // set khóa phụ

            builder.HasOne(c => c.KhachHang).
                WithMany().HasForeignKey(c => c.khachHangID);
            builder.HasOne(c =>c.NhanVien).
              WithMany().HasForeignKey(c => c.nhanVienID);
        }
    }
}
