using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HL7_CDASH_Export.Domain.CM
{
    [DataContract]
    public class CM
    {
        [DataMember]
        public string SUBJECTID { get; set; }

        [DataMember]
        public string CMYN { get; set; }

        [DataMember]
        public string CMSPID { get; set; }

        [DataMember]
        public string CMTRT { get; set; }

        [DataMember]
        public string CMOCCUR { get; set; }

        [DataMember]
        public string CMINGRD { get; set; }

        [DataMember]
        public string CMINDC { get; set; }

        [DataMember]
        public string CMAENO { get; set; }

        [DataMember]
        public string CMMHNO { get; set; }

        [DataMember]
        public string CMDSTXT { get; set; }

        [DataMember]
        public string CMDOSE { get; set; }

        [DataMember]
        public string CMDOSTOT { get; set; }

        [DataMember]
        public string CMUDOSU { get; set; }

        [DataMember]
        public string CMDOSFRM { get; set; }

        [DataMember]
        public string CMROUTE { get; set; }

        [DataMember]
        public string CMSTDTC { get; set; }

        [DataMember]
        public string CMSTDAT { get; set; }

        [DataMember]
        public string CMSTTIM { get; set; }

        [DataMember]
        public string CMPRIOR { get; set; }

        [DataMember]
        public string CMENDTC { get; set; }

        [DataMember]
        public string CMENDAT { get; set; }

        [DataMember]
        public string CMENTIM { get; set; }

        [DataMember]
        public string CMONGO { get; set; }

        [DataMember]
        public string CMDOSFRQ { get; set; }
    }
}