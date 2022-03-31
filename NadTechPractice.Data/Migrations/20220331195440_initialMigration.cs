using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NadTechPractice.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    PostCode = table.Column<string>(type: "TEXT", nullable: false),
                    HouseNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<long>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<long>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "DateModified", "Gender", "Name" },
                values: new object[] { 1L, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 20, 54, 38, 904, DateTimeKind.Local).AddTicks(5899), null, 0, "Clement Azibataram" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "CustomerId", "DateCreated", "DateModified", "HouseNumber", "PostCode", "Street" },
                values: new object[] { 1L, 1L, new DateTime(2022, 3, 31, 20, 54, 38, 941, DateTimeKind.Local).AddTicks(6691), null, 5, "1100021", "Ajasalane" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "DateCreated", "DateModified" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 593.89m, 1L, new DateTime(2022, 3, 31, 20, 54, 38, 944, DateTimeKind.Local).AddTicks(1288), null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "DateCreated", "DateModified" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 983.90m, 1L, new DateTime(2022, 3, 31, 20, 54, 38, 944, DateTimeKind.Local).AddTicks(4000), null });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerId",
                table: "Address",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
