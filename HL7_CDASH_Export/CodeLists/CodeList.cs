using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HL7_CDASH_Export.CodeLists
{
    [Serializable]
    public class CodeList
    {
        [XmlElement]
        public List<CodeListItem> CodeListItem { get; set; }
    }
}