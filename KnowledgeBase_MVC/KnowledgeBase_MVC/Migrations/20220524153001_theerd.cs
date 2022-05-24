using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeBase_MVC.Migrations
{
    public partial class theerd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConnectionCompanyProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EAN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectionCompanyProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectionCompanyProduct_Company_NameCompany",
                        column: x => x.NameCompany,
                        principalTable: "Company",
                        principalColumn: "NameCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectionCompanyProduct_Product_EAN",
                        column: x => x.EAN,
                        principalTable: "Product",
                        principalColumn: "EAN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectionCompanyService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameService = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectionCompanyService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectionCompanyService_Company_NameCompany",
                        column: x => x.NameCompany,
                        principalTable: "Company",
                        principalColumn: "NameCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectionCompanyService_Service_NameService",
                        column: x => x.NameService,
                        principalTable: "Service",
                        principalColumn: "NameService",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    NumberEmployee = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.NumberEmployee);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionCompanyProduct_EAN",
                table: "ConnectionCompanyProduct",
                column: "EAN");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionCompanyProduct_NameCompany",
                table: "ConnectionCompanyProduct",
                column: "NameCompany");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionCompanyService_NameCompany",
                table: "ConnectionCompanyService",
                column: "NameCompany");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionCompanyService_NameService",
                table: "ConnectionCompanyService",
                column: "NameService");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectionCompanyProduct");

            migrationBuilder.DropTable(
                name: "ConnectionCompanyService");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
