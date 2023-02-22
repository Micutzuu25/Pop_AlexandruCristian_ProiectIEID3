using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pop_AlexandruCristian_ProiectIEID3.Migrations
{
    public partial class AutomobilCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VanzatorID",
                table: "Automobil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vanzator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeVanzator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vanzator", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AutomobilCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutomobilID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomobilCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AutomobilCategory_Automobil_AutomobilID",
                        column: x => x.AutomobilID,
                        principalTable: "Automobil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomobilCategory_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobil_VanzatorID",
                table: "Automobil",
                column: "VanzatorID");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobilCategory_AutomobilID",
                table: "AutomobilCategory",
                column: "AutomobilID");

            migrationBuilder.CreateIndex(
                name: "IX_AutomobilCategory_CategoryID",
                table: "AutomobilCategory",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobil_Vanzator_VanzatorID",
                table: "Automobil",
                column: "VanzatorID",
                principalTable: "Vanzator",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobil_Vanzator_VanzatorID",
                table: "Automobil");

            migrationBuilder.DropTable(
                name: "AutomobilCategory");

            migrationBuilder.DropTable(
                name: "Vanzator");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Automobil_VanzatorID",
                table: "Automobil");

            migrationBuilder.DropColumn(
                name: "VanzatorID",
                table: "Automobil");
        }
    }
}
