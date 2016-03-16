using System;
using Gandalan.IDAS.UniDEx.Provider.Jobs;

namespace UniDEx_Demo.Jobs
{
    public class JobStatusViewModel
    {
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public DateTime Zeitstempel { get; set; }
        
        public JobStatusViewModel(JobStatus status)
        {
            StatusCode = status.StatusCode;
            StatusText = status.StatusText;
            Zeitstempel = status.Zeitstempel;
        }
    }
}