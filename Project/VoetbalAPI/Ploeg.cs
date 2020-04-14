using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoetbalAPI
{
    public class Ploeg
    {
        public int Id { get; set; }
        public string PloegNaam { get; set; }
        public string Gemeente { get; set; }
        public int Stamnummer { get; set; }
        public int Gewonnen { get; set; }
        public int Verloren { get; set; }
        public int Gelijkspel { get; set; }
        public int Punten { get; set; }
    }
}
