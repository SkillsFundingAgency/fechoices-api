using System.Threading.Tasks;
using Esfa.Fechoices.Api.Models;

namespace Esfa.Fechoices.Api.Services
{
    public interface IEmployerSatisfactionRepository
    {
        Task<EmployerSatisfaction> Get(int ukprn);
    }
}