using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeBase_MVC.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    NameCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationOfTheCompany = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.NameCompany);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    EAN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Coast = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.EAN);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    NameService = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coast = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.NameService);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    FIO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Post = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.FIO);
                    table.ForeignKey(
                        name: "FK_Person_Company_NameCompany",
                        column: x => x.NameCompany,
                        principalTable: "Company",
                        principalColumn: "NameCompany",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_NameCompany",
                table: "Person",
                column: "NameCompany");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
