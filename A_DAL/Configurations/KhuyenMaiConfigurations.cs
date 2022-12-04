using A_DAL.DomaninClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class KhuyenMaiConfigurations : IEntityTypeConfiguration<KhuyenMai>

    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.HasKey(c => c.id);
            builder.HasAlternateKey(x => x.Ma);
            builder.Property(c => c.Ma).HasColumnType("varchar(100)");
            builder.Property(c => c.mota).HasColumnType("nvarchar(100)");
            builder.Property(c => c.Ten).HasColumnType("nvarchar(100)");
            builder.Property(c => c.ngayTao).HasColumnType("datetime");
            builder.Property(c => c.NgayketThuc).HasColumnType("datetime");
            builder.Property(c => c.TrangThai).HasColumnType("int");
            builder.Property(c => c.SoLuongGiam).HasColumnType("float");

        }
    }
}
