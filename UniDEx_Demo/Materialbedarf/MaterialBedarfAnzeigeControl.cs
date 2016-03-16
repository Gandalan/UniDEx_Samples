using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gandalan.IDAS.UniDEx;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;

namespace UniDEx_Demo.Materialbedarf
{
    public partial class MaterialBedarfAnzeigeControl : UserControl
    {
        private UniDExContext _context;

        public MaterialBedarfAnzeigeControl()
        {
            InitializeComponent();
        }

        public void Initialisieren(UniDExContext context)
        {
            _context = context;
            ladeMaterialBedarf();
        }

        private void materialBedarfContainerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladeContainerInhalt();
        }

        #region Hilfsmethoden für Datenanzeige
        /// <summary>
        /// Lädt alle Materialbedarf-Container in die erste DataGridView
        /// </summary>
        private void ladeMaterialBedarf()
        {
            // Datenquellen entfernen und neu setzen
            materialBedarfContainerBindingSource.DataSource = typeof(MaterialBedarfContainer);
            // Datenquellen setzen
            materialBedarfContainerBindingSource.DataSource = _context.MaterialBedarf
                .OrderByDescending(e=>e.BelegJahr)
                .ThenByDescending(e => e.BelegNummer)
                .ThenByDescending(e => e.BelegPositionsNummer).ToList();
        }

        /// <summary>
        /// Lädt aus dem aktuell gewählten Container die Properties (Key/Value-Paare) und erstellt daraus 
        /// Businessobjekte. Beides wird dann in den beiden unteren DataGridViews angezeigt.
        /// </summary>
        private void ladeContainerInhalt()
        {
            // DataBinding leeren
            materialbedarfItemBindingSource.DataSource = typeof(MaterialbedarfItem);
            objectPropertyBindingSource.DataSource = typeof(ObjectProperty);

            // Daten anzeigen
            MaterialBedarfContainer container = materialBedarfContainerBindingSource.Current as MaterialBedarfContainer;
            if (container != null)
            {
                objectPropertyBindingSource.DataSource = container.ContainerValues;
                materialbedarfItemBindingSource.DataSource = MaterialbedarfRoutinen.GetItems(container);
            }
        }
        #endregion Hilfsmethoden für Datenanzeige        
    }
}
