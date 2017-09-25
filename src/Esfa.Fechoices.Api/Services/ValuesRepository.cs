using System.Collections.Generic;

namespace Esfa.Fechoices.Api.Services
{
    public class ValuesRepository : IValuesRepository
    {
        public IEnumerable<string> FindAll()
        {
            return new string[] { "value1", "value2" };
        }
    }
}