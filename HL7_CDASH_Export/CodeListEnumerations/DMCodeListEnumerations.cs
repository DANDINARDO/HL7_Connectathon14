using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HL7_CDASH_Export.CodeLists;

namespace HL7_CDASH_Export.CodeListEnumerations
{
    public class DMCodeListEnumerations
    {
        public CodeList GetSexEnumerations()
        {
            CodeList cl = new CodeList();
            List<CodeListItem> clItems = new List<CodeListItem>();
            CodeListItem clMale = new CodeListItem() {CodedValue = "M", Decode= new Decode() { TranslatedText = new TranslatedText() { lang = "en", Text = "Male" } } };
            CodeListItem clFemale = new CodeListItem() { CodedValue = "F", Decode = new Decode() { TranslatedText = new TranslatedText() { lang = "en", Text = "Female" } } };
            clItems.Add(clMale);
            clItems.Add(clFemale);
            cl.CodeListItem = clItems;
            return cl;
        }
    }
}