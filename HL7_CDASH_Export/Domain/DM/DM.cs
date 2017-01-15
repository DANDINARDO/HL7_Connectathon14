using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.Domain.DM
{
    [DataContract]
    public class DM
    {
        [DataMember]
        public string BRTHDAT { get; set; }

        [DataMember]
        public string BRTHYR { get; set; }

        [DataMember]
        public string BRTHMO { get; set; }

        [DataMember]
        public string BRTHDY { get; set; }

        [DataMember]
        public string BRTHTIM { get; set; }

        [DataMember]
        public string AGE { get; set; }

        [DataMember]
        public string AGEU { get; set; }

        [DataMember]
        public string DMDAT { get; set; }

        [DataMember]
        public string SEX { get; set; }

        [DataMember]
        public string ETHNIC { get; set; }

        [DataMember]
        public string RACEOTH { get; set; }

    }
}