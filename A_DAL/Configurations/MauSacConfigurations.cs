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
    public class MauSacConfigurations : IEntityTypeConfiguration<mauSac>
    {
        public void Configure(EntityTypeBuilder<mauSac> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasAlternateKey(x => x.Ma);
            builder.Property(x => x.Ma).HasColumnType("Varchar(100)");
            builder.Property(x => x.Ten).HasColumnType("NVarchar(100)");
        }
    }
}
