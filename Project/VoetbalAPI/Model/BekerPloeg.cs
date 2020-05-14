using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
//using System.Runtime.Serialization;

namespace VoetbalAPI.Model
{
   // [DataContract]
    public class BekerPloeg
    {
        public int BekerId { get; set; }
        [JsonIgnore]
        //[DataMember]
        public Beker Beker { get; set; }
        public int PloegId { get; set; }
        [JsonIgnore]
       // [DataMember]
        public Ploeg Ploeg { get; set; }
    }
}
