using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Document = table.Column<string>(nullable: true),
                    CorporateName = table.Column<string>(maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Document = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salerman",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Phone = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salerman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saller",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    SalesmanId = table.Column<Guid>(nullable: true),
                    Seller = table.Column<DateTime>(nullable: false),
                    TotalSale = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saller_Salerman_SalesmanId",
                        column: x => x.SalesmanId,
                        principalTable: "Salerman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    DiscountPrice = table.Column<decimal>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    EntitySallerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Saller_EntitySallerId",
                        column: x => x.EntitySallerId,
                        principalTable: "Saller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Salerman",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { new Guid("d6e884da-7d36-4378-8a32-d962f160bedc"), "admin@gmail.com", "admin", "21999999999" });

            migrationBuilder.CreateIndex(
                name: "IX_LegalPerson_Document",
                table: "LegalPerson",
                column: "Document",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalPerson_Document",
                table: "PhysicalPerson",
                column: "Document",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_EntitySallerId",
                table: "Product",
                column: "EntitySallerId");

            migrationBuilder.CreateIndex(
                name: "IX_Saller_SalesmanId",
                table: "Saller",
                column: "SalesmanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalPerson");

            migrationBuilder.DropTable(
                name: "PhysicalPerson");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Saller");

            migrationBuilder.DropTable(
                name: "Salerman");
        }
    }
}
