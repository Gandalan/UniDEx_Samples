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

namespace UniDEx_Demo.Texte
{
    public partial class TextAnzeigeControl : UserControl
    {
        private UniDExContext _context;

        public TextAnzeigeControl()
        {
            InitializeComponent();
        }

        public void Initialisieren(UniDExContext context)
        {
            _context = context;
            ladeTexte();
        }

        private void textInfoContainerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladeContainerInhalt();
        }

        #region Hilfsmethoden für Datenanzeige
        /// <summary>
        /// Lädt alle Materialbedarf-Container in die erste DataGridView
        /// </summary>
        private void ladeTexte()
        {
            // Datenquellen entfernen und neu setzen
            textInfoContainerBindingSource.DataSource = typeof(TextInfoContainer);
            // Datenquellen setzen
            textInfoContainerBindingSource.DataSource = _context.Texte
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
            textInfoItemBindingSource.DataSource = typeof(TextItem);
            objectPropertyBindingSource.DataSource = typeof(ObjectProperty);

            // Daten anzeigen
            TextInfoContainer container = textInfoContainerBindingSource.Current as TextInfoContainer;
            if (container != null)
            {
                objectPropertyBindingSource.DataSource = container.ContainerValues;
                textInfoItemBindingSource.DataSource = TextRoutinen.GetItems(container);
            }
        }
        #endregion Hilfsmethoden für Datenanzeige        
    }
}
