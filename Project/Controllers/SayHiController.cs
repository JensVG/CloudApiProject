using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/v1/ploegen")]
public class SayHiController : Controller
{
    [HttpGet]
    public List<Ploeg> GetPloegenStanden()
    {
        var list = new List<Ploeg>();

        list.Add(new Ploeg()
        {
            PloegNaam = "RSC Anderlecht",
            Gemeente = "Anderlecht",
            Stamnummer = 35,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Royal Antwerp FC",
            Gemeente = "Antwerpen",
            Stamnummer = 1,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Cercle Brugge",
            Gemeente = "Brugge",
            Stamnummer = 12,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });

        list.Add(new Ploeg()
        {
            PloegNaam = "Club Brugge",
            Gemeente = "Brugge",
            Stamnummer = 3,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Royal Charleroi Sporting Club",
            Gemeente = "Charleroi",
            Stamnummer = 22,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KAS Eupen",
            Gemeente = "Eupen",
            Stamnummer = 4276,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KRC Genk",
            Gemeente = "Genk",
            Stamnummer = 322,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KAA Gent",
            Gemeente = "Gent",
            Stamnummer = 7,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KV Kortrijk",
            Gemeente = "Kortrijk",
            Stamnummer = 19,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KV Mechelen",
            Gemeente = "Mechelen",
            Stamnummer = 25,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Royal Excel Moeskroen",
            Gemeente = "Moeskroen",
            Stamnummer = 216,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KV Oostende",
            Gemeente = "Oostende",
            Stamnummer = 31,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Sint-Truidense VV",
            Gemeente = "Sint-Truiden",
            Stamnummer = 373,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "Standard Luik",
            Gemeente = "Luik",
            Stamnummer = 16,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "KVRS Waasland- SK Beveren",
            Gemeente = "Beveren",
            Stamnummer = 4068,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        list.Add(new Ploeg()
        {
            PloegNaam = "SV Zulte Waregem",
            Gemeente = "Waregem",
            Stamnummer = 5381,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0
        });
        return list;
    }
    [Route("{stamnummer}")]
    [HttpGet]
    public ActionResult<Ploeg> GetPloegstand(int stamnummer)
    {
        if (stamnummer == 1)
        {
            var ploeg = new Ploeg()
            {
                PloegNaam = "Royal Antwerp FC",
                Gemeente = "Antwerpen",
                Stamnummer = 1,
                Gewonnen = 0,
                Verloren = 0,
                Gelijkspel = 0,
                Punten = 0
            };
            return ploeg;
        }
        else{
            return NotFound();
        }
    }
}