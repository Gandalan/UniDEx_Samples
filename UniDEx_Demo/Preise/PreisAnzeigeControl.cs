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
using Gandalan.IDAS.UniDEx.Provider.Preise;

namespace UniDEx_Demo.Preise
{
    public partial class PreisAnzeigeControl : UserControl
    {
        private UniDExContext _context;

        public PreisAnzeigeControl()
        {
            InitializeComponent();
        }

        public void Initialisieren(UniDExContext context)
        {
            _context = context;
            ladePreisInfos();
        }

        private void preisInfoContainerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladeContainerInhalt();
        }

        #region Hilfsmethoden für Datenanzeige
        /// <summary>
        /// Lädt alle Materialbedarf-Container in die erste DataGridView
        /// </summary>
        private void ladePreisInfos()
        {
            // Datenquellen entfernen und neu setzen
            preisInfoContainerBindingSource.DataSource = typeof(PreisInfoContainer);
            // Datenquellen setzen
            preisInfoContainerBindingSource.DataSource = _context.Preise
                .OrderByDescending(e => e.BelegJahr)
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
            preisInfoItemBindingSource.DataSource = typeof(PreisInfoItem);
            objectPropertyBindingSource.DataSource = typeof(ObjectProperty);

            // Daten anzeigen
            PreisInfoContainer container = preisInfoContainerBindingSource.Current as PreisInfoContainer;
            if (container != null)
            {
                objectPropertyBindingSource.DataSource = container.ContainerValues;
                preisInfoItemBindingSource.DataSource = PreisRoutinen.GetItems(container);
            }
        }
        #endregion Hilfsmethoden für Datenanzeige        
    }
}
