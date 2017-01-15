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
    public class eCRFDemography : IeCRFDemography
    {
        public DM GeteCRFDemography()
        {
            DM dm = new DM();
            return dm;
        }

        public DM PosteCRFDemography(DM dm)
        {
            return dm;
        }
    }
}
