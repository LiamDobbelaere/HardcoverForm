using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace hardcoverform.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesForms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aanvullend = table.Column<string>(nullable: true),
                    AfwijkendeBindwijze = table.Column<bool>(nullable: false),
                    AllOverDispersielak = table.Column<bool>(nullable: false),
                    AmerikaansStofwikkel = table.Column<bool>(nullable: false),
                    AndersZieAanvullend = table.Column<bool>(nullable: false),
                    Band = table.Column<string>(nullable: true),
                    BanderolBuikband = table.Column<bool>(nullable: false),
                    Bandmateriaal = table.Column<string>(nullable: true),
                    Bedrijfsnaam = table.Column<string>(nullable: true),
                    Binnenwerk = table.Column<string>(nullable: true),
                    Blinddruk = table.Column<bool>(nullable: false),
                    Contactpersoon = table.Column<string>(nullable: true),
                    DatumDoorsturen = table.Column<string>(nullable: true),
                    EenheidsprijsDigitaal = table.Column<bool>(nullable: false),
                    EenheidsprijsDrukproef = table.Column<bool>(nullable: false),
                    EenheidsprijsRgbCmyk = table.Column<bool>(nullable: false),
                    Emailadres = table.Column<string>(nullable: true),
                    Foliedruk = table.Column<bool>(nullable: false),
                    FormaatBoekblokGesloten = table.Column<string>(nullable: true),
                    FormaatOpen = table.Column<string>(nullable: true),
                    FransStofwikkel = table.Column<bool>(nullable: false),
                    Gequillotineerd = table.Column<bool>(nullable: false),
                    GlansLaminaat = table.Column<bool>(nullable: false),
                    HalflinnenBand = table.Column<bool>(nullable: false),
                    IndividueelKrimpfolie = table.Column<bool>(nullable: false),
                    Integraalband = table.Column<bool>(nullable: false),
                    Kapitaalbandje = table.Column<bool>(nullable: false),
                    KrasvastMatLami = table.Column<bool>(nullable: false),
                    Leeslintje = table.Column<bool>(nullable: false),
                    LinnenBand = table.Column<bool>(nullable: false),
                    MatLaminaat = table.Column<bool>(nullable: false),
                    MinOversteekPlatten = table.Column<bool>(nullable: false),
                    Oplage = table.Column<string>(nullable: true),
                    PapierBinnenwerk = table.Column<string>(nullable: true),
                    PapierSchutbladen = table.Column<string>(nullable: true),
                    PapierStofwikkel = table.Column<string>(nullable: true),
                    PapierenBand = table.Column<bool>(nullable: false),
                    Postadres = table.Column<string>(nullable: true),
                    RechteRug = table.Column<bool>(nullable: false),
                    RechteRugRol = table.Column<bool>(nullable: false),
                    RondeRug = table.Column<bool>(nullable: false),
                    Schutbladen = table.Column<string>(nullable: true),
                    SpotUv = table.Column<bool>(nullable: false),
                    Standaard = table.Column<bool>(nullable: false),
                    Stofwikkel = table.Column<string>(nullable: true),
                    Taalwissels = table.Column<bool>(nullable: false),
                    Werktitel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesForms", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesForms");
        }
    }
}
