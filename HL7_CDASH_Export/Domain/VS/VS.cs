using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.Domain.VS
{
    [DataContract]
    public class VS
    {
        [DataMember]
        public string SUBJECTID { get; set; }

        [DataMember]
        public string VSPERF { get; set; }

        [DataMember]
        public string VSDTC { get; set; }

        [DataMember]
        public string VSDAT { get; set; }

        [DataMember]
        public string VSTIN { get; set; }

        [DataMember]
        public string VSSPID { get; set; }

        [DataMember]
        public string VSORRES { get; set; }

        [DataMember]
        public string VSORRESU { get; set; }

        [DataMember]
        public string VSVLSIG { get; set; }

        [DataMember]
        public string VSLOC { get; set; }

        [DataMember]
        public string VSPOS { get; set; }

    }
}