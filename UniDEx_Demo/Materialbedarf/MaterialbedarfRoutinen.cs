using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;

namespace UniDEx_Demo.Materialbedarf
{
    public class MaterialbedarfRoutinen
    {
        /// <summary>
        /// Liest einen Container aus, der den Materialbedarf für eine Belegposition enthält. Die Materialien werden 
        /// in Businessobjekte projeziert.
        /// </summary>
        /// <param name="container">Container mit Materialbedarf-Informationen aus der UniDEx-Schnittstelle</param>
        /// <returns>Liste des Materials als Businessobjekte</returns>
        public static List<MaterialbedarfItem> GetItems(MaterialBedarfContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            List<MaterialbedarfItem> result = new List<MaterialbedarfItem>();

            foreach (var groupItem in container.ContainerValues.GroupBy(k => k.GroupGuid))
            {
                // Neues Objekt erzeugen, das mit Daten gefüllt wird
                MaterialbedarfItem businessObject = new MaterialbedarfItem() { Kennzeichen = groupItem.Key.ToString() };
                // Alle Items in diesem Container haben dasselbe Präfix
                // Beispiel: 
                //      Identifier = MontageRahmen_1.MR_3.Kennzeichen
                //      Präfix = MontageRahmen_1.MR_3.
                string praefix = groupItem.FirstOrDefault(item => item.Identifier.EndsWith(".Kennzeichen"))?.Identifier.Replace("Kennzeichen", "");
                // Alle Properties des Containers durchgehen und die benötigten Informationen ins BO mappen
                foreach (ObjectProperty property in groupItem)
                {
                    string cleanIdentifier = string.IsNullOrEmpty(praefix) ? property.Identifier : property.Identifier.Replace(praefix, "");
                    switch (cleanIdentifier)
                    {
                        case "KatalogNummer": businessObject.KatalogNummer = property.Value; break;
                        case "Stueckzahl": businessObject.Stueckzahl = int.Parse(property.Value); break;
                        case "Laufmeter": businessObject.Laufmeter = decimal.Parse(property.Value); break;
                        case "Einheit": businessObject.Einheit = property.Value; break;
                        case "Bezeichnung": businessObject.Bezeichnung = property.Value; break;
                        case "Farbe.Kuerzel": businessObject.Farbe = property.Value; break;
                        case "IstZuschnitt": businessObject.IstZuschnitt = bool.Parse(property.Value); break;
                    }
                }
                result.Add(businessObject);
            }

            return result.OrderBy(i => i.KatalogNummer).ToList();        
        }
    }
}
