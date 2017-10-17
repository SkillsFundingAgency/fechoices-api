using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Esfa.Fechoices.Api.Services;
using Esfa.Fechoices.Api.Netcore.IntegrationTests.StubServices;

namespace Esfa.Fechoices.Api.Netcore.IntegrationTests
{
    public class LearnerSatisfactionTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public LearnerSatisfactionTest()
        {
            var webhostbuilder = new WebHostBuilder()
                .UseStartup<Startup>()
                .ConfigureServices((x) => x.Remove(new ServiceDescriptor(typeof(ILearnerSatisfactionRepository), typeof(LearnerSatisfactionRepository), ServiceLifetime.Transient)))
                .ConfigureServices((y) => y.Add((new ServiceDescriptor(typeof(ILearnerSatisfactionRepository), typeof(LearnerSatisfactionTestRepository), ServiceLifetime.Singleton))));

            _server = new TestServer(webhostbuilder);
            _client = _server.CreateClient();
        }
        
        [Fact]
        public async Task Get()
        {
            var request = "/api/learner-satisfaction/1";
            var response = await _client.GetAsync(request);
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsStringAsync();
            Assert.NotNull(result.Result);
        }
    }
}
