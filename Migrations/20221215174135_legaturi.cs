using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class legaturi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "DescriereOras",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "Oras",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "Tara",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "Tara",
                table: "Oras");

            migrationBuilder.DropColumn(
                name: "Locatie",
                table: "Hotel");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Tara",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                table: "Tara",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Persoane",
                table: "Rezervare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSosire",
                table: "Rezervare",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPlecare",
                table: "Rezervare",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrasID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaraID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parere",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrasID",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaraID",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "Prezentare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrasID",
                table: "Prezentare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaraID",
                table: "Prezentare",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TaraID",
                table: "Oras",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Hotel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "PretCamera",
                table: "Hotel",
                type: "decimal(6,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OrasID",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaraID",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipCamera",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_HotelID",
                table: "Rezervare",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_OrasID",
                table: "Rezervare",
                column: "OrasID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_TaraID",
                table: "Rezervare",
                column: "TaraID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_HotelID",
                table: "Review",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_OrasID",
                table: "Review",
                column: "OrasID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_TaraID",
                table: "Review",
                column: "TaraID");

            migrationBuilder.CreateIndex(
                name: "IX_Prezentare_HotelID",
                table: "Prezentare",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Prezentare_OrasID",
                table: "Prezentare",
                column: "OrasID");

            migrationBuilder.CreateIndex(
                name: "IX_Prezentare_TaraID",
                table: "Prezentare",
                column: "TaraID");

            migrationBuilder.CreateIndex(
                name: "IX_Oras_TaraID",
                table: "Oras",
                column: "TaraID");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_OrasID",
                table: "Hotel",
                column: "OrasID");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_TaraID",
                table: "Hotel",
                column: "TaraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Oras_OrasID",
                table: "Hotel",
                column: "OrasID",
                principalTable: "Oras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Tara_TaraID",
                table: "Hotel",
                column: "TaraID",
                principalTable: "Tara",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Oras_Tara_TaraID",
                table: "Oras",
                column: "TaraID",
                principalTable: "Tara",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prezentare_Hotel_HotelID",
                table: "Prezentare",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prezentare_Oras_OrasID",
                table: "Prezentare",
                column: "OrasID",
                principalTable: "Oras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prezentare_Tara_TaraID",
                table: "Prezentare",
                column: "TaraID",
                principalTable: "Tara",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Hotel_HotelID",
                table: "Review",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Oras_OrasID",
                table: "Review",
                column: "OrasID",
                principalTable: "Oras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Tara_TaraID",
                table: "Review",
                column: "TaraID",
                principalTable: "Tara",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Hotel_HotelID",
                table: "Rezervare",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Oras_OrasID",
                table: "Rezervare",
                column: "OrasID",
                principalTable: "Oras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Tara_TaraID",
                table: "Rezervare",
                column: "TaraID",
                principalTable: "Tara",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Oras_OrasID",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Tara_TaraID",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Oras_Tara_TaraID",
                table: "Oras");

            migrationBuilder.DropForeignKey(
                name: "FK_Prezentare_Hotel_HotelID",
                table: "Prezentare");

            migrationBuilder.DropForeignKey(
                name: "FK_Prezentare_Oras_OrasID",
                table: "Prezentare");

            migrationBuilder.DropForeignKey(
                name: "FK_Prezentare_Tara_TaraID",
                table: "Prezentare");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Hotel_HotelID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Oras_OrasID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Tara_TaraID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Hotel_HotelID",
                table: "Rezervare");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Oras_OrasID",
                table: "Rezervare");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Tara_TaraID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_HotelID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_OrasID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_TaraID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Review_HotelID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_OrasID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_TaraID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Prezentare_HotelID",
                table: "Prezentare");

            migrationBuilder.DropIndex(
                name: "IX_Prezentare_OrasID",
                table: "Prezentare");

            migrationBuilder.DropIndex(
                name: "IX_Prezentare_TaraID",
                table: "Prezentare");

            migrationBuilder.DropIndex(
                name: "IX_Oras_TaraID",
                table: "Oras");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_OrasID",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_TaraID",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "OrasID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "TaraID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "OrasID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "TaraID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "OrasID",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "TaraID",
                table: "Prezentare");

            migrationBuilder.DropColumn(
                name: "TaraID",
                table: "Oras");

            migrationBuilder.DropColumn(
                name: "OrasID",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "TaraID",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "TipCamera",
                table: "Hotel");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Tara",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                table: "Tara",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Persoane",
                table: "Rezervare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Rezervare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSosire",
                table: "Rezervare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPlecare",
                table: "Rezervare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "Parere",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriereOras",
                table: "Prezentare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "Prezentare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Oras",
                table: "Prezentare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Prezentare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tara",
                table: "Prezentare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tara",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Hotel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PretCamera",
                table: "Hotel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Locatie",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
