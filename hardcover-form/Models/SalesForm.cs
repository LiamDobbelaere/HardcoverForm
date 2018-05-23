using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hardcover_form.Models
{
    public class SalesForm
    {
        public int ID { get; set; }
        public string Dikte { get; set; }
        public string Aanvullend { get; set; }
        public bool AfwijkendeBindwijze { get; set; }
        public bool AllOverDispersielak { get; set; }
        public bool AmerikaansStofwikkel { get; set; }
        public bool AndersZieAanvullend { get; set; }
        public string Band { get; set; }
        public bool BanderolBuikband { get; set; }
        public string Bandmateriaal { get; set; }
        public string Bedrijfsnaam { get; set; }
        public string Binnenwerk { get; set; }
        public bool Blinddruk { get; set; }
        public string Contactpersoon { get; set; }
        public string DatumDoorsturen { get; set; }
        public bool EenheidsprijsDigitaal { get; set; }
        public bool EenheidsprijsDrukproef { get; set; }
        public bool EenheidsprijsRgbCmyk { get; set; }
        public string Emailadres { get; set; }
        public bool Foliedruk { get; set; }
        public string FormaatBoekblokGesloten { get; set; }
        public string FormaatOpen { get; set; }
        public bool FransStofwikkel { get; set; }
        public bool Gequillotineerd { get; set; }
        public bool GlansLaminaat { get; set; }
        public bool HalflinnenBand { get; set; }
        public bool IndividueelKrimpfolie { get; set; }
        public bool Integraalband { get; set; }
        public bool Kapitaalbandje { get; set; }
        public bool KrasvastMatLami { get; set; }
        public bool Leeslintje { get; set; }
        public bool LinnenBand { get; set; }
        public bool MatLaminaat { get; set; }
        public bool MinOversteekPlatten { get; set; }
        public string Oplage { get; set; }
        public string PapierBinnenwerk { get; set; }
        public string PapierSchutbladen { get; set; }
        public string PapierStofwikkel { get; set; }
        public bool PapierenBand { get; set; }
        public string Postadres { get; set; }
        public bool RechteRug { get; set; }
        public bool RechteRugRol { get; set; }
        public bool RondeRug { get; set; }
        public string Schutbladen { get; set; }
        public bool SpotUv { get; set; }
        public bool Standaard { get; set; }
        public string Stofwikkel { get; set; }
        public bool Taalwissels { get; set; }
        public string Werktitel { get; set; }
    }
}
