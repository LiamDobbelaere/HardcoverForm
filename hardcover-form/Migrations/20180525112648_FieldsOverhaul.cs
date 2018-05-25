using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace hardcoverform.Migrations
{
    public partial class FieldsOverhaul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stofwikkel",
                table: "SalesForms",
                newName: "Voorbespreken");

            migrationBuilder.RenameColumn(
                name: "Standaard",
                table: "SalesForms",
                newName: "TariefBeeldbewerkingPerUur");

            migrationBuilder.RenameColumn(
                name: "SpotUv",
                table: "SalesForms",
                newName: "RechteRugVanRol");

            migrationBuilder.RenameColumn(
                name: "Schutbladen",
                table: "SalesForms",
                newName: "Toelichting");

            migrationBuilder.RenameColumn(
                name: "RechteRugRol",
                table: "SalesForms",
                newName: "RechteRugInleg");

            migrationBuilder.RenameColumn(
                name: "RechteRug",
                table: "SalesForms",
                newName: "OpenBestanden");

            migrationBuilder.RenameColumn(
                name: "Postadres",
                table: "SalesForms",
                newName: "Telefoon");

            migrationBuilder.RenameColumn(
                name: "MatLaminaat",
                table: "SalesForms",
                newName: "OmzettingAfbeeldingProfiel");

            migrationBuilder.RenameColumn(
                name: "KrasvastMatLami",
                table: "SalesForms",
                newName: "InkjetKleurproef");

            migrationBuilder.RenameColumn(
                name: "Integraalband",
                table: "SalesForms",
                newName: "IndividueelOnderKrimpfolie");

            migrationBuilder.RenameColumn(
                name: "IndividueelKrimpfolie",
                table: "SalesForms",
                newName: "HandzameDubbelgolfkartonnenDozen");

            migrationBuilder.RenameColumn(
                name: "GlansLaminaat",
                table: "SalesForms",
                newName: "DrukproefOpOplagepapier");

            migrationBuilder.RenameColumn(
                name: "Foliedruk",
                table: "SalesForms",
                newName: "CertifiedPDFs");

            migrationBuilder.RenameColumn(
                name: "EenheidsprijsRgbCmyk",
                table: "SalesForms",
                newName: "BedrukkingZeefdruk");

            migrationBuilder.RenameColumn(
                name: "EenheidsprijsDrukproef",
                table: "SalesForms",
                newName: "BedrukkingSpotUV");

            migrationBuilder.RenameColumn(
                name: "EenheidsprijsDigitaal",
                table: "SalesForms",
                newName: "BedrukkingMatLaminaat");

            migrationBuilder.RenameColumn(
                name: "Dikte",
                table: "SalesForms",
                newName: "PrijsCommercieelOverleggen");

            migrationBuilder.RenameColumn(
                name: "Blinddruk",
                table: "SalesForms",
                newName: "BedrukkingKrasvastMatLaminaat");

            migrationBuilder.RenameColumn(
                name: "Binnenwerk",
                table: "SalesForms",
                newName: "PlanningGekend");

            migrationBuilder.RenameColumn(
                name: "Bandmateriaal",
                table: "SalesForms",
                newName: "PapierDiktePlatten");

            migrationBuilder.RenameColumn(
                name: "BanderolBuikband",
                table: "SalesForms",
                newName: "BedrukkingGlansLaminaat");

            migrationBuilder.RenameColumn(
                name: "Band",
                table: "SalesForms",
                newName: "PapierBand");

            migrationBuilder.RenameColumn(
                name: "AndersZieAanvullend",
                table: "SalesForms",
                newName: "BedrukkingFoliedruk");

            migrationBuilder.RenameColumn(
                name: "AllOverDispersielak",
                table: "SalesForms",
                newName: "BedrukkingBlinddruk");

            migrationBuilder.RenameColumn(
                name: "Aanvullend",
                table: "SalesForms",
                newName: "Offertenummer");

            migrationBuilder.AddColumn<string>(
                name: "AantalPaginasBinnenwerk",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AfleveradresBekend",
                table: "SalesForms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Banderol",
                table: "SalesForms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BedrukkingAlloverDispersielak",
                table: "SalesForms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BedrukkingAndersZieToelichting",
                table: "SalesForms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BedrukkingBinnenwerk",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedrukkingSchutbladen",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedrukkingStofwikkel",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Herdruk",
                table: "SalesForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Klant",
                table: "SalesForms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AantalPaginasBinnenwerk",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "AfleveradresBekend",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Banderol",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "BedrukkingAlloverDispersielak",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "BedrukkingAndersZieToelichting",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "BedrukkingBinnenwerk",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "BedrukkingSchutbladen",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "BedrukkingStofwikkel",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Herdruk",
                table: "SalesForms");

            migrationBuilder.DropColumn(
                name: "Klant",
                table: "SalesForms");

            migrationBuilder.RenameColumn(
                name: "Voorbespreken",
                table: "SalesForms",
                newName: "Stofwikkel");

            migrationBuilder.RenameColumn(
                name: "Toelichting",
                table: "SalesForms",
                newName: "Schutbladen");

            migrationBuilder.RenameColumn(
                name: "Telefoon",
                table: "SalesForms",
                newName: "Postadres");

            migrationBuilder.RenameColumn(
                name: "TariefBeeldbewerkingPerUur",
                table: "SalesForms",
                newName: "Standaard");

            migrationBuilder.RenameColumn(
                name: "RechteRugVanRol",
                table: "SalesForms",
                newName: "SpotUv");

            migrationBuilder.RenameColumn(
                name: "RechteRugInleg",
                table: "SalesForms",
                newName: "RechteRugRol");

            migrationBuilder.RenameColumn(
                name: "PrijsCommercieelOverleggen",
                table: "SalesForms",
                newName: "Dikte");

            migrationBuilder.RenameColumn(
                name: "PlanningGekend",
                table: "SalesForms",
                newName: "Binnenwerk");

            migrationBuilder.RenameColumn(
                name: "PapierDiktePlatten",
                table: "SalesForms",
                newName: "Bandmateriaal");

            migrationBuilder.RenameColumn(
                name: "PapierBand",
                table: "SalesForms",
                newName: "Band");

            migrationBuilder.RenameColumn(
                name: "OpenBestanden",
                table: "SalesForms",
                newName: "RechteRug");

            migrationBuilder.RenameColumn(
                name: "OmzettingAfbeeldingProfiel",
                table: "SalesForms",
                newName: "MatLaminaat");

            migrationBuilder.RenameColumn(
                name: "Offertenummer",
                table: "SalesForms",
                newName: "Aanvullend");

            migrationBuilder.RenameColumn(
                name: "InkjetKleurproef",
                table: "SalesForms",
                newName: "KrasvastMatLami");

            migrationBuilder.RenameColumn(
                name: "IndividueelOnderKrimpfolie",
                table: "SalesForms",
                newName: "Integraalband");

            migrationBuilder.RenameColumn(
                name: "HandzameDubbelgolfkartonnenDozen",
                table: "SalesForms",
                newName: "IndividueelKrimpfolie");

            migrationBuilder.RenameColumn(
                name: "DrukproefOpOplagepapier",
                table: "SalesForms",
                newName: "GlansLaminaat");

            migrationBuilder.RenameColumn(
                name: "CertifiedPDFs",
                table: "SalesForms",
                newName: "Foliedruk");

            migrationBuilder.RenameColumn(
                name: "BedrukkingZeefdruk",
                table: "SalesForms",
                newName: "EenheidsprijsRgbCmyk");

            migrationBuilder.RenameColumn(
                name: "BedrukkingSpotUV",
                table: "SalesForms",
                newName: "EenheidsprijsDrukproef");

            migrationBuilder.RenameColumn(
                name: "BedrukkingMatLaminaat",
                table: "SalesForms",
                newName: "EenheidsprijsDigitaal");

            migrationBuilder.RenameColumn(
                name: "BedrukkingKrasvastMatLaminaat",
                table: "SalesForms",
                newName: "Blinddruk");

            migrationBuilder.RenameColumn(
                name: "BedrukkingGlansLaminaat",
                table: "SalesForms",
                newName: "BanderolBuikband");

            migrationBuilder.RenameColumn(
                name: "BedrukkingFoliedruk",
                table: "SalesForms",
                newName: "AndersZieAanvullend");

            migrationBuilder.RenameColumn(
                name: "BedrukkingBlinddruk",
                table: "SalesForms",
                newName: "AllOverDispersielak");
        }
    }
}
