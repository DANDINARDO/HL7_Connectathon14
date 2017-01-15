using HL7_CDASH_Export.Domain.VS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HL7_CDASH_Export.Domain.DM;
using Newtonsoft.Json;

namespace HL7_CDASH_Export
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "eCRFVitalSigns" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select eCRFVitalSigns.svc or eCRFVitalSigns.svc.cs at the Solution Explorer and start debugging.
    public class eCRFVitalSigns : IeCRFVitalSigns
    {
        public VS GeteCRFVitalSigns(string Id)
        {
            VS vs = new VS()
            {
                SUBJECTID = "1",
                VSPERF = "Y",
                VSDAT = "2001-01-12",
                VSTEST = "HEIGHT",
                VSORRESU = "In"
            };
            return vs;
        }

        public VS PosteCRFVitalSigns(VS vs)
        {
            return vs;
        }
    }
}
