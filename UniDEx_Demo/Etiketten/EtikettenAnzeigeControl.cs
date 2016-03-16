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
using Gandalan.IDAS.UniDEx.Provider.Texte;
using Gandalan.IDAS.UniDEx.Provider.Etiketten;

namespace UniDEx_Demo.Etiketten
{
    public partial class EtikettenAnzeigeControl : UserControl
    {
        private UniDExContext _context;

        public EtikettenAnzeigeControl()
        {
            InitializeComponent();
        }

        public void Initialisieren(UniDExContext context)
        {
            _context = context;
            ladeEtiketten();
        }

        private void etikettenInfoContainerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladeContainerInhalt();
        }

        #region Hilfsmethoden für Datenanzeige
        /// <summary>
        /// Lädt alle Materialbedarf-Container in die erste DataGridView
        /// </summary>
        private void ladeEtiketten()
        {
            // Datenquellen entfernen und neu setzen
            etikettenInfoContainerBindingSource.DataSource = typeof(EtikettenInfoContainer);
            // Datenquellen setzen
            etikettenInfoContainerBindingSource.DataSource = _context.Etiketten
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
            etikettenInfoItemBindingSource.DataSource = typeof(EtikettenItem);
            objectPropertyBindingSource.DataSource = typeof(ObjectProperty);

            // Daten anzeigen
            EtikettenInfoContainer container = etikettenInfoContainerBindingSource.Current as EtikettenInfoContainer;
            if (container != null)
            {
                objectPropertyBindingSource.DataSource = container.ContainerValues;
                etikettenInfoItemBindingSource.DataSource = EtikettenRoutinen.GetItems(container);
            }
        }
        #endregion Hilfsmethoden für Datenanzeige        
    }
}
