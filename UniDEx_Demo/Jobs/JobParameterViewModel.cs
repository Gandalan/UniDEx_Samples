using System;
using Gandalan.IDAS.UniDEx.Provider.Jobs;

namespace UniDEx_Demo.Jobs
{
    public class JobParameterViewModel
    {
        public string DatenTyp { get; set; }
        public Guid JobParameterId { get; set; }
        public string Name { get; set; }
        public string Richtung { get; set; }
        public string Wert { get; set; }

        public JobParameterViewModel(JobParameter parameter)
        {
            DatenTyp = parameter.DatenTyp;
            JobParameterId = parameter.JobParameterId;
            Name = parameter.Name;
            Richtung = parameter.Richtung;
            Wert = parameter.Wert;
        }
    }
}