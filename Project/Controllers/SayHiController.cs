using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class SayHiController : Controller
{
    [Route("Competitie")]
    [HttpGet]
    public List<Ploegenstand> GetPloegenStanden()
    {
        var list = new List<Ploegenstand>();

        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "RSC Anderlecht",
            Gemeente = "Anderlecht",
            Stamnummer = 35,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Royal Antwerp FC",
            Gemeente = "Antwerpen",
            Stamnummer = 1,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Cercle Brugge",
            Gemeente = "Brugge",
            Stamnummer = 12,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });

        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Club Brugge",
            Gemeente = "Brugge",
            Stamnummer = 3,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Royal Charleroi Sporting Club",
            Gemeente = "Charleroi",
            Stamnummer = 22,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KAS Eupen",
            Gemeente = "Eupen",
            Stamnummer = 4276,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KRC Genk",
            Gemeente = "Genk",
            Stamnummer = 322,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KAA Gent",
            Gemeente = "Gent",
            Stamnummer = 7,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KV Kortrijk",
            Gemeente = "Kortrijk",
            Stamnummer = 19,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KV Mechelen",
            Gemeente = "Mechelen",
            Stamnummer = 25,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Royal Excel Moeskroen",
            Gemeente = "Moeskroen",
            Stamnummer = 216,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KV Oostende",
            Gemeente = "Oostende",
            Stamnummer = 31,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Sint-Truidense VV",
            Gemeente = "Sint-Truiden",
            Stamnummer = 373,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "Standard Luik",
            Gemeente = "Luik",
            Stamnummer = 16,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "KVRS Waasland- SK Beveren",
            Gemeente = "Beveren",
            Stamnummer = 4068,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        list.Add(new Ploegenstand()
        {
            Voetbalploeg = "SV Zulte Waregem",
            Gemeente = "Waregem",
            Stamnummer = 5381,
            Gewonnen = 0,
            Verloren = 0,
            Gelijkspel = 0,
            Punten = 0,
        });
        return list;
    }
}