using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VoetbalAPI
{
    public class Speler
    {
        public int Id { get; set; }

        [Required]
        public string PloegNaam { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Woontplaats { get; set; }
        public string Positie { get; set; }
        public int Rugnummer { get; set; }
        public int GeleKaarten { get; set; }
        public int RodeKaarten { get; set; }
        public int AantalGoalen { get; set; }
        public int AantalAssisten { get; set; }
    }
}
