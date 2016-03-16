using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniDEx_Demo.Etiketten
{
    public class EtikettenItem
    {
        /// <summary>
        /// Eindeutiges Kennzeichen des Items (aus GUID)
        /// </summary>
        public string Kennzeichen { get; set; }

        /// <summary>
        /// Ausführlicher Text für Belegposition
        /// </summary>
        public string Text { get; set; }
    }
}
