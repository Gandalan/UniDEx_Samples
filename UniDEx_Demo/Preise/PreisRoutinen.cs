using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;
using Gandalan.IDAS.UniDEx.Provider.Preise;

namespace UniDEx_Demo.Preise
{
    public class PreisRoutinen
    {
        /// <summary>
        /// Liest einen Container aus, der den Materialbedarf für eine Belegposition enthält. Die Materialien werden 
        /// in Businessobjekte projeziert.
        /// </summary>
        /// <param name="container">Container mit Materialbedarf-Informationen aus der UniDEx-Schnittstelle</param>
        /// <returns>Liste des Materials als Businessobjekte</returns>
        public static List<PreisInfoItem> GetItems(PreisInfoContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            List<PreisInfoItem> result = new List<PreisInfoItem>();
            PreisInfoItem businessObject = new PreisInfoItem() { Kennzeichen = container.ContainerGuid.ToString() };
                
            foreach (var groupItem in container.ContainerValues)
            {
                // Neues Objekt erzeugen, das mit Daten gefüllt wird
                // Alle Properties des Containers durchgehen und die benötigten Informationen ins BO mappen
                switch (groupItem.Identifier)
                {
                    case "Preis.PreisTabelle": businessObject.ElementPreis = decimal.Parse(groupItem.Value); break;
                    case "Preis.Gesamtpreis_laut_Liste": businessObject.Gesamtpreis_laut_Liste = decimal.Parse(groupItem.Value); break;
                    case "Preis.Gesamtpreis_Rabattiert": businessObject.Gesamtpreis_Rabattiert = decimal.Parse(groupItem.Value); break;
                    case "Preis.Rabatt": businessObject.Rabatt = decimal.Parse(groupItem.Value); break;
                    case "Preis.Rabatt2": businessObject.Rabatt2 = decimal.Parse(groupItem.Value); break;
                    case "Preis.WaehrungsFaktor": businessObject.WaehrungsFaktor = groupItem.Value; break;
                    case "Preis.WaehrungsSymbol": businessObject.WaehrungsSymbol = groupItem.Value; break;
                    case "Aufpreis.Aufpreise": businessObject.Aufpreise = decimal.Parse(groupItem.Value); break;
                    case "Aufpreis.Aufpreise2": businessObject.Aufpreise2 = decimal.Parse(groupItem.Value); break;                    
                }                
            }

            result.Add(businessObject);
            return result;        
        }
    }
}
