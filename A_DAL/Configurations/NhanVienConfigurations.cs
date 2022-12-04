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
    public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(c => c.id);
      //      builder.HasAlternateKey(x => x.Ma);
            builder.Property(c => c.ChuVuId).IsRequired();
          //  builder.Property(c => c.GuiBcId);
            builder.Property(c => c.Anhid).IsRequired();
            builder.Property(c => c.Ma).HasColumnType("varchar(100)");
            builder.Property(c => c.Ten).HasColumnType("nvarchar(100)");
            builder.Property(c => c.TenDem).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Ho).HasColumnType("nvarchar(100)");
            builder.Property(c => c.NgaySinh).HasColumnType("datetime");
            builder.Property(c => c.sdt).HasColumnType("varchar(100)");
            builder.Property(c => c.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(c => c.MatKhau).HasColumnType("varchar(100)");
            builder.Property(c => c.gioitinh).HasColumnType("int");
            builder.Property(c => c.Trangthai).HasColumnType("int");

            // set khoa ngoai
            builder.HasOne(c => c.ChucVu).WithMany()
                .HasForeignKey(c => c.ChuVuId);
            builder.HasOne(c => c.anh).WithMany()
              .HasForeignKey(c => c.Anhid);
            builder.HasOne(c => c.Guibc).WithMany();
              
            

        }
    }
}
