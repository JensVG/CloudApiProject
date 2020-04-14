using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VoetbalAPI.Controllers
{
    [Route("api/v1/spelers")]
    [ApiController]
    public class SpelersController : ControllerBase
    {
        private readonly CompetitieContext context;

        public SpelersController(CompetitieContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Speler> GetAllSpelers()
        {
            return context.Spelers.ToList();
        }
    }
}
