using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MvcPractice1.Migrations
{
    public partial class Supplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierCode",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Code);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_SupplierCode",
                table: "Items",
                column: "SupplierCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierCode",
                table: "Items",
                column: "SupplierCode",
                principalTable: "Suppliers",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierCode",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Items_SupplierCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SupplierCode",
                table: "Items");
        }
    }
}
