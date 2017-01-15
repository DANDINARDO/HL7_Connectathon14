using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.CodeLists
{
    public class TranslatedText
    {
        [XmlAttribute(Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}