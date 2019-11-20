using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: " Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KHName = table.Column<string>(maxLength: 32, nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    OderMoney = table.Column<string>(nullable: true),
                    OderAddress = table.Column<string>(nullable: true),
                    OrderStartTime = table.Column<DateTime>(nullable: false),
                    OrderOverTime = table.Column<DateTime>(nullable: false),
                    ServiceEployee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: " Record",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    YGName = table.Column<string>(maxLength: 32, nullable: false),
                    Log = table.Column<string>(nullable: true),
                    ServiceStartTime = table.Column<DateTime>(nullable: false),
                    ServiceOverTime = table.Column<DateTime>(nullable: false),
                    CustomerData = table.Column<string>(nullable: true),
                    CustomerEvaluation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Record", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KHName = table.Column<string>(maxLength: 256, nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    TransactionNumber = table.Column<int>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_ Order_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: " Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Basic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    YGName = table.Column<string>(maxLength: 256, nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    TypeService = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Introduction = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Identity = table.Column<string>(nullable: true),
                    Professional = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true),
                    Handle = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basic_ Record_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: " Record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basic_EmployeeId",
                table: "Basic",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerId",
                table: "Customer",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basic");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: " Record");

            migrationBuilder.DropTable(
                name: " Order");
        }
    }
}
