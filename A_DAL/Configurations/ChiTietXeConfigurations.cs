using A_DAL.DomaninClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class ChiTietXeConfigurations : IEntityTypeConfiguration<ChiTietXe>
    {
        public void Configure(EntityTypeBuilder<ChiTietXe> builder)
        {
            builder.ToTable("ChiTietXe");
            builder.HasKey(x => x.id);
            builder.Property(c => c.mauSacID).HasColumnName("idMauSac");//.IsRequired();
            builder.Property(c => c.NSXID).HasColumnName("isNSX");//.IsRequired();
            builder.Property(c => c.LoaiXeID).HasColumnName("idLoaiXe");//.IsRequired();
            builder.Property(c => c.SanPhamID).HasColumnName("idSanPham");//.IsRequired();
            builder.Property(c => c.DongCoID).HasColumnName("idDongCo");//.IsRequired();
            builder.Property(c => c.anhID).HasColumnName("IdAnh");//.IsRequired();
            builder.Property(c => c.khoiDongID).HasColumnName("idKhoiDong");//.IsRequired();
            builder.Property(c => c.NgayNhap).HasColumnType("datetime") ;
            builder.Property(c => c.namBh).HasColumnType("float") ;
            builder.Property(c => c.soKhung).HasColumnType("varchar(100)") ;
            builder.Property(c => c.soMay).HasColumnType("varchar(100)") ;
            builder.Property(c => c.binhXang).HasColumnType("nvarchar(100)") ;
            builder.Property(c => c.moTa).HasColumnType("Nvarchar(600)") ;

            builder.Property(c => c.SoLuongTon).HasColumnType("decimal(20,0)") ;
            builder.Property(c => c.giaNhap).HasColumnType("decimal(20,0)") ;
            builder.Property(c => c.giaBan).HasColumnType("decimal(20,0)") ;
            builder.Property(c => c.TrangThai).HasColumnType("int") ;


            // set khóa ngoại
            builder.HasOne(x => x.MauSac)
                .WithMany().HasForeignKey(p => p.mauSacID);
            builder.HasOne(x => x.NSX)
               .WithMany().HasForeignKey(p => p.NSXID);
            builder.HasOne(x => x.LoaiXe)
               .WithMany().HasForeignKey(p => p.LoaiXeID);
            builder.HasOne(x => x.SanPham)
               .WithMany().HasForeignKey(p => p.SanPhamID);
            builder.HasOne(x => x.DongCo)
               .WithMany().HasForeignKey(p => p.DongCoID);
            builder.HasOne(x => x.Anh)
               .WithMany().HasForeignKey(p => p.anhID);
            builder.HasOne(x => x.khoidong)
               .WithMany().HasForeignKey(p => p.khoiDongID);
            

        }
    }
}
