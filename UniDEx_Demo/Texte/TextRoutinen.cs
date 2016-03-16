using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;
using Gandalan.IDAS.UniDEx.Provider.Texte;

namespace UniDEx_Demo.Texte
{
    public class TextRoutinen
    {
        /// <summary>
        /// Liest einen Container aus, der die Texte für eine Belegposition enthält. Die Texte werden 
        /// in Businessobjekte projeziert.
        /// </summary>
        /// <param name="container">Container mit Text-Informationen aus der UniDEx-Schnittstelle</param>
        /// <returns>Liste der Texte als Businessobjekte</returns>
        public static List<TextItem> GetItems(TextInfoContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            List<TextItem> result = new List<TextItem>();

            foreach (var item in container.ContainerValues)
            {
                if (item.Identifier == "BelegPosition_ausfuehrlich")
                {
                    // Neues Objekt erzeugen, das mit Daten gefüllt wird
                    TextItem businessObject = new TextItem() { Kennzeichen = item.ObjectPropertyGuid.ToString(), Positionstext_Ausfuehrlich = item.Value };
                    result.Add(businessObject);
                }
            }

            return result;
        }
    }
}
