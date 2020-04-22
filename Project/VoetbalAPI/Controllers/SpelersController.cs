using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetSpeler(int id)
        {
            var speler = context.Spelers
               .Include(d => d.Ploeg)
               .SingleOrDefault(d => d.Id == id);

            if (speler == null)
            {
                return NotFound();
            }
            return Ok(speler);
        }

        [HttpPost]
        public IActionResult CreateSpeler([FromBody] Speler newSpeler)
        {
            context.Spelers.Add(newSpeler);
            context.SaveChanges();
            return Created("", newSpeler);
        }
        [HttpPut]
        public IActionResult UpdateSpeler([FromBody] Speler updateSpeler)
        {
            var orgSpeler = context.Spelers.Find(updateSpeler.Id);
            if (orgSpeler == null)
            {
                return NotFound();
            }
            orgSpeler.Voornaam = updateSpeler.Voornaam;
            orgSpeler.Achternaam = updateSpeler.Achternaam;
            orgSpeler.Woonplaats = updateSpeler.Woonplaats;
            orgSpeler.Email = updateSpeler.Email;
            orgSpeler.Positie = updateSpeler.Positie;
            orgSpeler.Rugnummer = updateSpeler.Rugnummer;
            orgSpeler.GeleKaarten = updateSpeler.GeleKaarten;
            orgSpeler.RodeKaarten = updateSpeler.RodeKaarten;
            orgSpeler.AantalGoalen = updateSpeler.AantalGoalen;
            orgSpeler.AantalAssisten = updateSpeler.AantalAssisten;

        context.SaveChanges();
            return Ok(orgSpeler);
        }
        [HttpDelete]
        public IActionResult DeleteSpeler(int id)
        {
            var speler = context.Spelers.Find(id);
            if (speler == null)
            {
                return NotFound();
            }
            context.Spelers.Remove(speler);
            context.SaveChanges();
            return NoContent();
        }
    }
}
