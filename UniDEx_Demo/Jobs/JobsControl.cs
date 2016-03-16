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
using Gandalan.IDAS.UniDEx.Provider.Jobs;

namespace UniDEx_Demo.Jobs
{
    public partial class JobsControl : UserControl
    {
        private UniDExContext _context;

        public JobsControl()
        {
            InitializeComponent();
        }

        public void Initialisieren(UniDExContext context)
        {
            _context = context;
            ladeJobs();
        }

        private void ladeJobs()
        {
            jobViewModelBindingSource.DataSource = typeof(JobViewModel);
            List<JobViewModel> viewModels = new List<JobViewModel>();
            foreach (Job j in _context.Jobs.ToList().OrderByDescending(j => j.Geaendert))
            {
                viewModels.Add(new JobViewModel(j));
            }
            jobViewModelBindingSource.DataSource = viewModels;
        }
        
    }
}
