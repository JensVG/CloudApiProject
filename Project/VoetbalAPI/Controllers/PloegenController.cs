using System;
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

        [Route("{Id}")]
        [HttpGet]
        public IActionResult GetPloeg(int Id)
        {
            var ploeg = context.Ploegen.Find(Id);
            if (ploeg == null)
            {
                return NotFound();
            }
            return Ok(ploeg);
        }
        [HttpPost]
        public IActionResult CreatePloeg([FromBody] Ploeg newPloeg)
        {
            context.Ploegen.Add(newPloeg);
            context.SaveChanges();
            return Created("",newPloeg);
        }
        [HttpPut]
        public IActionResult UpdatePloeg([FromBody] Ploeg updatePloeg)
        {
            var orgPloeg = context.Ploegen.Find(updatePloeg.Id);
            if(orgPloeg == null)
            {
                return NotFound();
            }
            orgPloeg.Punten = updatePloeg.Punten;
            orgPloeg.PloegNaam = updatePloeg.PloegNaam;
            orgPloeg.Gemeente = updatePloeg.Gemeente;
            orgPloeg.Website = updatePloeg.Website;
            orgPloeg.Email = updatePloeg.Email;
            orgPloeg.Stamnummer = updatePloeg.Stamnummer;
            orgPloeg.Gewonnen = updatePloeg.Gewonnen;
            orgPloeg.Verloren = updatePloeg.Verloren;
            orgPloeg.Gelijkspel = updatePloeg.Gelijkspel;
            orgPloeg.Punten = updatePloeg.Punten;

            context.SaveChanges();
            return Ok(orgPloeg);
    }
        [HttpDelete]
        public IActionResult DeletePloeg(int id)
        {
            var ploeg = context.Ploegen.Find(id);
            if (ploeg == null)
            {
                return NotFound();
            }
            context.Ploegen.Remove(ploeg);
            context.SaveChanges();
            return NoContent();
        }
    }
}

