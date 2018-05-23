using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace hardcoverform.Migrations
{
    public partial class DikteAlsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "DikteStandaard",
                table: "SalesForms",
                newName: "Dikte");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dikte",
                table: "SalesForms",
                newName: "DikteStandaard");

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
        }
    }
}
