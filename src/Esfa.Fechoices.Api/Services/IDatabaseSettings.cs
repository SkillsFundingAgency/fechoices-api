using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Esfa.Fechoices.Api.Services
{
    public class DatabaseSettings
    {
        public string FeChoicesConnectionString => Environment.GetEnvironmentVariable("DAS_ACHIEVEMENTRATEDATABASECONNECTIONSTRING", EnvironmentVariableTarget.User);
    }
}