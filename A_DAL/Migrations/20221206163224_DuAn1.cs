using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A_DAL.Migrations
{
    public partial class DuAn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    Ten = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    link = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DongCos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongCos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(30)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    gioitinh = table.Column<int>(type: "int", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "varchar(100)", nullable: true),
                    ThanhPho = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuocGia = table.Column<string>(type: "varchar(100)", nullable: true),
                    trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhoiDongs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoiDongs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    mota = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ngayTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayketThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    SoLuongGiam = table.Column<double>(type: "float", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiXes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiXes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NSXes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSXes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "NVarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuiBcId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Anhid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    sdt = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(100)", nullable: true),
                    gioitinh = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.id);
                    table.ForeignKey(
                        name: "FK_NhanViens_Anh_Anhid",
                        column: x => x.Anhid,
                        principalTable: "Anh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_ChuVuId",
                        column: x => x.ChuVuId,
                        principalTable: "ChucVus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanViens_NhanViens_GuiBcId",
                        column: x => x.GuiBcId,
                        principalTable: "NhanViens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietXe",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    isNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idLoaiXe = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idDongCo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idKhoiDong = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: true),
                    namBh = table.Column<double>(type: "float", nullable: true),
                    soKhung = table.Column<string>(type: "varchar(100)", nullable: true),
                    soMay = table.Column<string>(type: "varchar(100)", nullable: true),
                    binhXang = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    moTa = table.Column<string>(type: "Nvarchar(600)", nullable: true),
                    SoLuongTon = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    giaBan = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    giaNhap = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietXe", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_Anh_IdAnh",
                        column: x => x.IdAnh,
                        principalTable: "Anh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_DongCos_idDongCo",
                        column: x => x.idDongCo,
                        principalTable: "DongCos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_KhoiDongs_idKhoiDong",
                        column: x => x.idKhoiDong,
                        principalTable: "KhoiDongs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_LoaiXes_idLoaiXe",
                        column: x => x.idLoaiXe,
                        principalTable: "LoaiXes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_MauSacs_idMauSac",
                        column: x => x.idMauSac,
                        principalTable: "MauSacs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_NSXes_isNSX",
                        column: x => x.isNSX,
                        principalTable: "NSXes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietXe_SanPhams_idSanPham",
                        column: x => x.idSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    khachHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nhanVienID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MA = table.Column<string>(type: "varchar(100)", nullable: true),
                    ngayTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    ngayThanhToan = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayMongMuon = table.Column<DateTime>(type: "datetime", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "Nvarchar(100)", nullable: true),
                    trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_khachHangID",
                        column: x => x.khachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_nhanVienID",
                        column: x => x.nhanVienID,
                        principalTable: "NhanViens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChitiets",
                columns: table => new
                {
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChiTietXeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhuyenMaiID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "Decimal", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "Decimal", nullable: true),
                    trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HoaDonChitiets_ChiTietXe_ChiTietXeId",
                        column: x => x.ChiTietXeId,
                        principalTable: "ChiTietXe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChitiets_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChitiets_KhuyenMais_KhuyenMaiID",
                        column: x => x.KhuyenMaiID,
                        principalTable: "KhuyenMais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_IdAnh",
                table: "ChiTietXe",
                column: "IdAnh");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_idDongCo",
                table: "ChiTietXe",
                column: "idDongCo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_idKhoiDong",
                table: "ChiTietXe",
                column: "idKhoiDong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_idLoaiXe",
                table: "ChiTietXe",
                column: "idLoaiXe");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_idMauSac",
                table: "ChiTietXe",
                column: "idMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_idSanPham",
                table: "ChiTietXe",
                column: "idSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXe_isNSX",
                table: "ChiTietXe",
                column: "isNSX");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChitiets_ChiTietXeId",
                table: "HoaDonChitiets",
                column: "ChiTietXeId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChitiets_HoaDonId",
                table: "HoaDonChitiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChitiets_KhuyenMaiID",
                table: "HoaDonChitiets",
                column: "KhuyenMaiID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_khachHangID",
                table: "HoaDons",
                column: "khachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_nhanVienID",
                table: "HoaDons",
                column: "nhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_Anhid",
                table: "NhanViens",
                column: "Anhid");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_ChuVuId",
                table: "NhanViens",
                column: "ChuVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_GuiBcId",
                table: "NhanViens",
                column: "GuiBcId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChitiets");

            migrationBuilder.DropTable(
                name: "ChiTietXe");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "DongCos");

            migrationBuilder.DropTable(
                name: "KhoiDongs");

            migrationBuilder.DropTable(
                name: "LoaiXes");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "NSXes");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "ChucVus");
        }
    }
}
