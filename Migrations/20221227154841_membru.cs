using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class membru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Rezervare");

            migrationBuilder.AddColumn<int>(
                name: "MembruID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Membru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membru", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_MembruID",
                table: "Rezervare",
                column: "MembruID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Membru_MembruID",
                table: "Rezervare",
                column: "MembruID",
                principalTable: "Membru",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Membru_MembruID",
                table: "Rezervare");

            migrationBuilder.DropTable(
                name: "Membru");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_MembruID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "MembruID",
                table: "Rezervare");

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
