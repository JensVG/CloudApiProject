using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoetbalAPI
{
    public class Speler
    {
        public int Id { get; set; }
        public string PloegNaam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Woontplaats { get; set; }
        public string Positie { get; set; }
        public int Rugnummer { get; set; }
        public int GeleKaarten { get; set; }
        public int RodeKaarten { get; set; }
        public int AantalGoalen { get; set; }
        public int AantalAssisten { get; set; }
    }
}
