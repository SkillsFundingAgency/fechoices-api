using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esfa.Fechoices.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esfa.Fechoices.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/employer-satisfaction")]
    public class EmployerSatisfactionController : Controller
    {
        private readonly ILearnerSatisfactionRepository _repository;

        public EmployerSatisfactionController(ILearnerSatisfactionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{ukprn}")]
        public async Task<IActionResult> Get(int ukprn)
        {
            var record = await _repository.Get(ukprn);
            if (record == null)
            {
                return NotFound();
            }

            return Ok(record);
        }
    }
}