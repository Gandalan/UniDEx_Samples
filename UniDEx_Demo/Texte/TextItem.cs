using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDEx_Demo.Texte
{
    public class TextItem
    {
        /// <summary>
        /// Eindeutiges Kennzeichen des Items (aus GUID)
        /// </summary>
        public string Kennzeichen { get; set; }

        /// <summary>
        /// Ausführlicher Text für Belegposition
        /// </summary>
        public string Positionstext_Ausfuehrlich { get; set; }
    }
}
