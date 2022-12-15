using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class prezentare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prezentare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriereOras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
       
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prezentare", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prezentare");
        }
    }
}
