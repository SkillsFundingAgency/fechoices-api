using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Esfa.Fechoices.Api.Models;
using Esfa.Fechoices.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esfa.Fechoices.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/learner-satisfaction")]
    public class LearnerSatisfactionController : Controller
    {
        private readonly ILearnerSatisfactionRepository _repository;

        public LearnerSatisfactionController(ILearnerSatisfactionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{ukprn}")]
        public async Task<IActionResult> Get(int ukprn)
        {
            var record = _repository.Get(ukprn);
            if (record == null)
            {
                return NotFound();
            }

            return Ok(record);
        }
    }
}