using Esfa.Fechoices.Api.Models;

namespace Esfa.Fechoices.Api.Services
{
    public interface ILearnerSatisfactionRepository
    {
        LearnerSatisfaction Get(int ukprn);
    }
}