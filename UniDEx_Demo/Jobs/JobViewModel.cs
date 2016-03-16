using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gandalan.IDAS.UniDEx.Provider.Jobs;

namespace UniDEx_Demo.Jobs
{
    public class JobViewModel
    {
        public DateTime Erstellt { get; }
        public DateTime Geaendert { get; }
        public Guid JobId { get; set; }
        public List<JobParameterViewModel> Parameter { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public List<JobStatusViewModel> Stati { get; set; }

        public JobViewModel(Job source)
        {
            Erstellt = source.Erstellt;
            Geaendert = source.Geaendert;
            JobId = source.JobId;
            Recipient = source.Recipient;
            Sender = source.Sender;

            Stati = new List<JobStatusViewModel>();
            List<JobStatus> stati = source.GetOrderedStati();
            stati.Reverse();
            foreach (JobStatus status in stati)
                Stati.Add(new JobStatusViewModel(status));

            Parameter = new List<JobParameterViewModel>();
            foreach (JobParameter parameter in source.Parameter.OrderByDescending(p => p.Richtung).ThenBy(p => p.Name))
                Parameter.Add(new JobParameterViewModel(parameter));
        }
    }
}
