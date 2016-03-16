using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Etiketten;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;
using Gandalan.IDAS.UniDEx.Provider.Texte;

namespace UniDEx_Demo.Etiketten
{
    public class EtikettenRoutinen
    {
        /// <summary>
        /// Liest einen Container aus, der die Texte für eine Belegposition enthält. Die Texte werden 
        /// in Businessobjekte projeziert.
        /// </summary>
        /// <param name="container">Container mit Text-Informationen aus der UniDEx-Schnittstelle</param>
        /// <returns>Liste der Texte als Businessobjekte</returns>
        public static List<EtikettenItem> GetItems(EtikettenInfoContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            List<EtikettenItem> result = new List<EtikettenItem>();

            foreach (var item in container.ContainerValues)
            {
                EtikettenItem businessObject = new EtikettenItem() { Kennzeichen = item.ObjectPropertyGuid.ToString(), Text = item.Value };
                result.Add(businessObject);
            }

            return result;
        }
    }
}
