using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locatie",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipCamera",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locatie",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "Locatie",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "TipCamera",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Locatie",
                table: "Review");
        }
    }
}
