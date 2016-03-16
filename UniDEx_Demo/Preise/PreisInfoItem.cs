using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDEx_Demo.Preise
{
    public class PreisInfoItem
    {
        /// <summary>
        /// Eindeutiges Kennzeichen des Items (aus GUID)
        /// </summary>
        public string Kennzeichen { get; set; }
        public decimal Gesamtpreis_laut_Liste { get; set; }
        public decimal Gesamtpreis_Rabattiert { get; set; }
        public decimal Rabatt { get; set; }
        public decimal Rabatt2 { get; set; }
        public string WaehrungsFaktor { get; set; }
        public string WaehrungsSymbol { get; set; }
        public decimal ElementPreis { get; set; }
        public decimal Aufpreise { get; set; }
        public decimal Aufpreise2 { get; set; }
    }
}
