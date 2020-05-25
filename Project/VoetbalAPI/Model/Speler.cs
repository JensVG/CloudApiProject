using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VoetbalAPI.Model
{
    public class Speler
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Woonplaats { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Positie { get; set; }
        [Required]
        [Range(1,99)]
        public int Rugnummer { get; set; }
        [Required]
        public int GeleKaarten { get; set; }
        [Required]
        public int RodeKaarten { get; set; }
        [Required]
        public int AantalGoalen { get; set; }
        [Required]
        public int AantalAssisten { get; set; }
        public Ploeg Ploeg { get; set; }
    }
}
