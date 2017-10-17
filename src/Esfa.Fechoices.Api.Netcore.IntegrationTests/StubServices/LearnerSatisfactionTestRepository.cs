using Esfa.Fechoices.Api.Services;
using Esfa.Fechoices.Api.Models;

namespace Esfa.Fechoices.Api.Netcore.IntegrationTests.StubServices
{
    public class LearnerSatisfactionTestRepository : ILearnerSatisfactionRepository
    {
        public LearnerSatisfaction Get(int ukprn)
        {
            return new LearnerSatisfaction { Ukprn = ukprn, FinalScore = 9.9, ResponseCount = 1, TotalCount = 1 };
        }
    }
}
