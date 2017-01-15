using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.CodeLists
{
    [Serializable]
    public class Decode
    {
        [XmlElement]
        public TranslatedText TranslatedText { get; set; }
    }
}