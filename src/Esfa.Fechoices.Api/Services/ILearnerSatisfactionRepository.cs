using System.Threading.Tasks;
using Esfa.Fechoices.Api.Models;

namespace Esfa.Fechoices.Api.Services
{
    public interface ILearnerSatisfactionRepository
    {
        Task<LearnerSatisfaction> Get(int ukprn);
    }
}