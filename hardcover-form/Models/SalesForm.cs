using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hardcover_form.Models
{
    public class SalesForm
    {
        public int ID { get; set; }
        
        //Klant
        public string Bedrijfsnaam { get; set; }
        public string Contactpersoon { get; set; }
        [Display(Name ="E-mailadres")]
        public string Emailadres { get; set; }
        public string Telefoon { get; set; }
        public string Klant { get; set; }
        public string Adres { get; set; }

        //Offerte
        public string Werktitel { get; set; }
        public string Herdruk { get; set; }
        public string Offertenummer { get; set; }
        [Display(Name ="Datum doorsturen")]
        public string DatumDoorsturen { get; set; }
        public string Oplage { get; set; }
        [Display(Name ="Planning gekend")]
        public string PlanningGekend { get; set; }
        public string Voorbespreken { get; set; }
        [Display(Name ="Prijs commercieel overleggen")]
        public string PrijsCommercieelOverleggen { get; set; }

        //Technische gegevens hardcover
        [Display(Name ="Aantal pagina's binnenwerk")]
        public string AantalPaginasBinnenwerk { get; set; }
        [Display(Name ="Formaat boekblok gesloten")]
        public string FormaatBoekblokGesloten { get; set; }
        [Display(Name ="Formaat open")]
        public string FormaatOpen { get; set; }

        //Technische gegevens hardcover - Uitvoering
        [Display(Name ="Rechte rug (inleg)")]
        public bool RechteRugInleg { get; set; }
        public bool Leeslintje { get; set; }
        [Display(Name ="Halflinnen Band")]
        public bool HalflinnenBand { get; set; }
        [Display(Name ="Banderol (buikband)")]
        public bool Banderol { get; set; }
        [Display(Name ="Afwijkende bindwijze")]
        public bool AfwijkendeBindwijze { get; set; }
        [Display(Name ="Ronde rug")]
        public bool RondeRug { get; set; }
        public bool Gequillotineerd { get; set; }
        [Display(Name ="Rechte rug van rol")]
        public bool RechteRugVanRol { get; set; }
        [Display(Name ="Frans stofwikkel")]
        public bool FransStofwikkel { get; set; }
        [Display(Name ="Papieren band")]
        public bool PapierenBand { get; set; }
        public bool Kapitaalbandje { get; set; }
        [Display(Name ="Linnen band")]
        public bool LinnenBand { get; set; }
        [Display(Name ="Amerikaans stofwikkel")]
        public bool AmerikaansStofwikkel { get; set; }
        public bool Taalwissels { get; set; }
        [Display(Name ="Min. oversteek platten")]
        public bool MinOversteekPlatten { get; set; }

        //Papier
        [Display(Name ="Binnenwerk")]
        public string PapierBinnenwerk { get; set; }
        [Display(Name = "Schutbladen")]
        public string PapierSchutbladen { get; set; }
        [Display(Name = "Band")]
        public string PapierBand { get; set; }
        [Display(Name = "Stofwikkel")]
        public string PapierStofwikkel { get; set; }
        [Display(Name = "Dikte platten")]
        public string PapierDiktePlatten { get; set; }

        //Bedrukking
        [Display(Name = "Binnenwerk")]
        public string BedrukkingBinnenwerk { get; set; }
        [Display(Name = "Schutbladen")]
        public string BedrukkingSchutbladen { get; set; }
        [Display(Name = "Stofwikkel")]
        public string BedrukkingStofwikkel { get; set; }

        //Bedrukking - Band
        [Display(Name = "Mat laminaat")]
        public bool BedrukkingMatLaminaat { get; set; }
        [Display(Name = "Glans laminaat")]
        public bool BedrukkingGlansLaminaat { get; set; }
        [Display(Name = "Krasvast mat laminaat")]
        public bool BedrukkingKrasvastMatLaminaat { get; set; }
        [Display(Name = "Foliedruk")]
        public bool BedrukkingFoliedruk { get; set; }
        [Display(Name = "Blinddruk")]
        public bool BedrukkingBlinddruk { get; set; }
        [Display(Name = "Spot UV")]
        public bool BedrukkingSpotUV { get; set; }
        [Display(Name = "Zeefdruk")]
        public bool BedrukkingZeefdruk { get; set; }
        [Display(Name = "All over dispersielak")]
        public bool BedrukkingAlloverDispersielak { get; set; }
        [Display(Name = "Anders, zie toelichting")]
        public bool BedrukkingAndersZieToelichting { get; set; }

        //Prepress
        [Display(Name = "Certified PDFs")]
        public bool CertifiedPDFs { get; set; }
        [Display(Name = "Open bestanden")]
        public bool OpenBestanden { get; set; }
        [Display(Name = "Inkjet kleurproef")]
        public bool InkjetKleurproef { get; set; }
        [Display(Name = "Drukproef op oplagepapier")]
        public bool DrukproefOpOplagepapier { get; set; }
        [Display(Name = "Omzetting afbeeldingen naar juiste profiel")]
        public bool OmzettingAfbeeldingProfiel { get; set; }
        [Display(Name = "Tarief beeldbewerking per uur")]
        public bool TariefBeeldbewerkingPerUur { get; set; }

        //Verpakking
        [Display(Name = "Handzame dubbelgolfkartonnen dozen")]
        public bool HandzameDubbelgolfkartonnenDozen { get; set; }
        [Display(Name = "Individueel onder krimpfolie (los specifieren)")]
        public bool IndividueelOnderKrimpfolie { get; set; }
        [Display(Name = "Afleveradres bekend?")]
        public bool AfleveradresBekend { get; set; }

        //Toelichting
        public string Toelichting { get; set; }
    }
}
