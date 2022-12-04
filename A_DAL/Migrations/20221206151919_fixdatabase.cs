using Microsoft.EntityFrameworkCore.Migrations;

namespace A_DAL.Migrations
{
    public partial class fixdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_SanPhams_Ma",
                table: "SanPhams");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_NSXes_Ma",
                table: "NSXes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_NhanViens_Ma",
                table: "NhanViens");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_MauSacs_Ma",
                table: "MauSacs");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_LoaiXes_Ma",
                table: "LoaiXes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_KhuyenMais_Ma",
                table: "KhuyenMais");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_KhoiDongs_Ma",
                table: "KhoiDongs");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_KhachHangs_Ma",
                table: "KhachHangs");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_HoaDons_MA",
                table: "HoaDons");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DongCos_Ma",
                table: "DongCos");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ChucVus_Ma",
                table: "ChucVus");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "SanPhams",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NSXes",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanViens",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "MauSacs",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "LoaiXes",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhuyenMais",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhoiDongs",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHangs",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "MA",
                table: "HoaDons",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "DongCos",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChucVus",
                type: "Varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "SanPhams",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NSXes",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanViens",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "MauSacs",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "LoaiXes",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhuyenMais",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhoiDongs",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHangs",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MA",
                table: "HoaDons",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "DongCos",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChucVus",
                type: "Varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_SanPhams_Ma",
                table: "SanPhams",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_NSXes_Ma",
                table: "NSXes",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_NhanViens_Ma",
                table: "NhanViens",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_MauSacs_Ma",
                table: "MauSacs",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LoaiXes_Ma",
                table: "LoaiXes",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_KhuyenMais_Ma",
                table: "KhuyenMais",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_KhoiDongs_Ma",
                table: "KhoiDongs",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_KhachHangs_Ma",
                table: "KhachHangs",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_HoaDons_MA",
                table: "HoaDons",
                column: "MA");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DongCos_Ma",
                table: "DongCos",
                column: "Ma");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ChucVus_Ma",
                table: "ChucVus",
                column: "Ma");
        }
    }
}
