using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Esfa.Fechoices.Api.Models;
using Microsoft.Extensions.Options;

namespace Esfa.Fechoices.Api.Services
{
    public class EmployerSatisfactionRepository : IEmployerSatisfactionRepository
    {
        private const string EmployerSatisfactionRatesTableName = "[dbo].[EmployerSatisf_2015_2016]";

        private readonly IOptions<DatabaseSettings> _settings;

        public EmployerSatisfactionRepository(IOptions<DatabaseSettings> settings)
        {
            _settings = settings;
        }

        public Task<EmployerSatisfaction> Get(int ukprn)
        {
            using (var connection = new SqlConnection(_settings.Value.FeChoicesConnectionString))
            {
                connection.Open();
                var query = $@"
                    SELECT  [UKPRN]
                    ,       [Final_Score] AS FinalScore
                    ,       [Employers] AS TotalCount
                    ,       [Responses] AS ResponseCount
                    FROM    {EmployerSatisfactionRatesTableName}
                    ";

                return connection.QueryFirstAsync<EmployerSatisfaction>(query, new { ukprn });
            }
        }
    }
}