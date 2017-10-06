using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Esfa.Fechoices.Api.Services
{
    public class DatabaseSettings
    {
        private const string sqlazureconnstrFechoices = "SQLAZURECONNSTR_FEChoices";

        public string FeChoicesConnectionString => Environment.GetEnvironmentVariable(sqlazureconnstrFechoices) ??
                                                   Environment.GetEnvironmentVariable(sqlazureconnstrFechoices, EnvironmentVariableTarget.User);
    }
}