using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pop_AlexandruCristian_ProiectIEID3.Migrations
{
    public partial class DataAparitie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Automobil",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAparitie",
                table: "Automobil",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAparitie",
                table: "Automobil");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Automobil",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
