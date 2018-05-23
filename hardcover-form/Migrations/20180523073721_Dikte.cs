using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace hardcoverform.Migrations
{
    public partial class Dikte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dikte15mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dikte1mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dikte25mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dikte2mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dikte3mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dikte4mm",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DikteStandaard",
                table: "SalesForms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dikte15mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Dikte1mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Dikte25mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Dikte2mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Dikte3mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Dikte4mm",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "DikteStandaard",
                table: "SalesForms");
        }
    }
}
