using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDEx_Demo.Produktion
{
    public class ProduktionItem
    {
        /// <summary>
        /// Eindeutiges Kennzeichen des Items (aus GUID)
        /// </summary>
        public string Kennzeichen { get; set; }

        /// <summary>
        /// Neher-Katalognummer des Artikels
        /// </summary>
        public string KatalogNummer { get; set; }

        /// <summary>
        /// Artikelbezeichnung
        /// </summary>
        public string Bezeichnung { get; set; }

        /// <summary>
        /// Farbe (Neher-Kürzel oder Sonderfarbton)
        /// </summary>
        public string Farbe { get; set; }

        /// <summary>
        /// Einheit des Artikels (lfm=Laufmeter, Stk=Stück, qm=Quadratmeter)
        /// </summary>
        public string Einheit { get; set; }

        /// <summary>
        /// Anzahl des Artikels (gleiche Artikel werden per Standard nicht zusammengefasst; schließt 
        /// sich aus mit Laufmeter!)
        /// </summary>
        public int Stueckzahl { get; set; }

        /// <summary>
        /// Laufmeter des Artikels (gleiche Artikel werden per Standard nicht zusammengefasst; schließt 
        /// sich aus mit Stückzahl!)
        /// </summary>
        public decimal Laufmeter { get; set; }

        /// <summary>
        /// Kennzeichen für Zuschnittartikel
        /// </summary>
        public bool IstZuschnitt { get; set; }
    }
}
