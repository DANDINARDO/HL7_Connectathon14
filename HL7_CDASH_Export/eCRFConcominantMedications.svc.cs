using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HL7_CDASH_Export.Domain.CM;
using Newtonsoft.Json;

namespace HL7_CDASH_Export
{
    public class eCRFConcominantMedications : IeCRFConcominantMedications
    {
        public CM GeteCRFConcominantMedications()
        {
            CM cm = new CM();
            return cm;
        }

        public CM PosteCRFConcominantMedications(CM cm)
        {
            return cm;
        }
    }
}
