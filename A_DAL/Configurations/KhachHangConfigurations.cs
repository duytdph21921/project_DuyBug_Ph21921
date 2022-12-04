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
    public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(c => c.id);
            builder.Property(c => c.Ma).HasColumnType("varchar(30)");
            builder.HasAlternateKey(x => x.Ma);

            builder.Property(c => c.Ten).HasColumnType("nvarchar(100)");
            builder.Property(c => c.TenDem).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Ho).HasColumnType("nvarchar(100)");
            builder.Property(c => c.NgaySinh).HasColumnType("datetime");
            builder.Property(c => c.gioitinh).HasColumnType("int");
            builder.Property(c => c.sdt).HasColumnType("nvarchar(100)");
            builder.Property(c => c.DiaChi).HasColumnType("varchar(100)");
            builder.Property(c => c.ThanhPho).HasColumnType("varchar(100)");
            builder.Property(c => c.QuocGia).HasColumnType("varchar(100)");
            builder.Property(c => c.trangthai).HasColumnType("int");
        }
    }
}
