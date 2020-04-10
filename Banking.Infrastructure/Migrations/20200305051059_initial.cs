using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Banking.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NationalCode = table.Column<string>(nullable: true),
                    Birth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    HomeAddress_Street = table.Column<string>(nullable: true),
                    HomeAddress_City = table.Column<string>(nullable: true),
                    HomeAddress_PostalCode = table.Column<string>(nullable: true),
                    Phone_Code = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
