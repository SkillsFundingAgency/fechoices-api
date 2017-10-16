namespace Esfa.Fechoices.Api.Models
{
    public class EmployerSatisfaction
    {
        public int Ukprn { get; set; }

        public double? FinalScore { get; set; }

        public int TotalCount { get; set; }

        public int ResponseCount { get; set; }
    }
}