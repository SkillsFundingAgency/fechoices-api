using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Esfa.Fechoices.Api.Models;
using Microsoft.Extensions.Options;

namespace Esfa.Fechoices.Api.Services
{
    public class LearnerSatisfactionRepository : ILearnerSatisfactionRepository
    {
        private const string LearnerSatisfactionRatesTableName = "[dbo].[LearnerSatisf_2015_2016]";

        private readonly IOptions<DatabaseSettings> _settings;

        public LearnerSatisfactionRepository(IOptions<DatabaseSettings> settings)
        {
            _settings = settings;
        }

        public LearnerSatisfaction Get(int ukprn)
        {
            using (var connection = new SqlConnection(_settings.Value.FeChoicesConnectionString))
            {
                connection.Open();
                var query = $@"
                    SELECT  [UKPRN]
                    ,       [Final_Score] AS FinalScore
                    ,       [Learners] AS TotalCount
                    ,       [Responses] AS ResponseCount
                    FROM    {LearnerSatisfactionRatesTableName}
                    WHERE   UKPRN = @ukprn";

                return connection.Query<LearnerSatisfaction>(query, new {ukprn}).FirstOrDefault();
            }
        }
    }
}
