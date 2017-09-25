using System.Collections.Generic;

namespace Esfa.Fechoices.Api.Services
{
    public interface IValuesRepository
    {
        IEnumerable<string> FindAll();
    }
}