﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace VoetbalAPI.Controllers
{
    [Route("api/v1/ploegen")]
    [ApiController]
    public class PloegenController : ControllerBase
    {
        private readonly CompetitieContext context;

        public PloegenController(CompetitieContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Ploeg> GetPloegen()
        {
            return context.Ploegen.ToList();
        }

        [Route("{stamnummer}")]
        [HttpGet]
        public IActionResult GetPloeg(int stamnummer)
        {
            var ploeg = context.Ploegen.Find(stamnummer);
            if (ploeg == null)
            {
                return NotFound();
            }
            return Ok(ploeg);
        }
    }
}
