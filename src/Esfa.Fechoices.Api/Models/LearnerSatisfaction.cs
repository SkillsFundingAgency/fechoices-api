using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esfa.Fechoices.Api.Models
{
    public class LearnerSatisfaction
    {
        public int Ukprn { get; set; }

        public double? FinalScore { get; set; }

        public int TotalCount { get; set; }

        public int ResponseCount { get; set; }
    }
}
