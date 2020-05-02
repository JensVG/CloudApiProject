using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoetbalAPI.Model
{
    public class BekerPloeg
    {
        public int Id { get; set; }
        public int BekerId { get; set; }
        public Beker Beker { get; set; }
        public int PloegId { get; set; }
        public Ploeg Ploeg { get; set; }
    }
}
