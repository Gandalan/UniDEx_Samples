using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gandalan.IDAS.Data.Models;
using Gandalan.IDAS.UniDEx;
using Gandalan.IDAS.UniDEx.Models;
using Gandalan.IDAS.UniDEx.Provider.Materialbedarf;
using UniDEx_Demo.Materialbedarf;

namespace UniDEx_Demo
{
    public partial class MainForm : Form
    {
        private UniDExContext _context;

        public MainForm()
        {
            InitializeComponent();           
        }

        #region UI-Eventhandler
        private void MainForm_Load(object sender, EventArgs e)
        {
            datenAktualisieren();
        }

        private void aktualisierenButton_Click(object sender, EventArgs e)
        {
            datenAktualisieren();
        }
        #endregion

        private void datenAktualisieren()
        {
            _context = new UniDExContext(new SqlConnection("Data Source=.\\GANDALAN;Initial Catalog=IBOS2_UniDEx;Integrated Security=true;"));
            materialBedarfAnzeigeControl.Initialisieren(_context);
            textAnzeigeControl.Initialisieren(_context);
            etikettenAnzeigeControl.Initialisieren(_context);
            preisAnzeigeControl.Initialisieren(_context);
            jobsControl.Initialisieren(_context);
        }
    }
}
