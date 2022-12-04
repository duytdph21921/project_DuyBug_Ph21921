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
    public class HoaDonChiTietConfigurations : IEntityTypeConfiguration<HoaDonChitiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChitiet> builder)
        {
           // builder.HasKey(c=>c.ChiTietXeId && c.HoaDonId && c.KhuyenMaiID)
            builder.Property(x => x.KhuyenMaiID).IsRequired();
            builder.Property(x => x.HoaDonId).IsRequired()  ;
            builder.Property(x => x.ChiTietXeId).IsRequired();

            builder.Property(x => x.soLuong).HasColumnType("int");
            builder.Property(x => x.DonGia).HasColumnType("Decimal");
            builder.Property(x => x.ThanhTien).HasColumnType("Decimal");
            builder.Property(x => x.trangthai).HasColumnType("int");
            // set khoa ngoại
            builder.HasNoKey();
            builder.HasOne(c => c.HoaDon)
                .WithMany().HasForeignKey(c => c.HoaDonId);
            builder.HasOne(c => c.ChiTietXe)
                .WithMany().HasForeignKey(c => c.ChiTietXeId);
            builder.HasOne(c => c.KhuyenMai)
                .WithMany().HasForeignKey(c => c.KhuyenMaiID);
        }
    }
}
