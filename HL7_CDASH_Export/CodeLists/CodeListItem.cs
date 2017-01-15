using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.CodeLists
{
    [Serializable]
    public class CodeListItem
    {
        [XmlAttribute]
        public string CodedValue { get; set; }

        [XmlElement]
        public Decode Decode { get; set; }
    }
}