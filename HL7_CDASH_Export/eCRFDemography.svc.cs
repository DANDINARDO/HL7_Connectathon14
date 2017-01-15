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
        public DM GeteCRFDemography(string Id)
        {
            DM dm = new DM()
            {
                SUBJECTID = "1",
                AGE = "34",
                AGEU = "MU.YEARS_2011-10-24",
                BRTHDAT = "1982-08-10",
                BRTHDY = "10",
                BRTHMO = "8",
                BRTHTIM = "10:34",
                BRTHYR = "1982",
                DMDAT = "2017-01-14",
                ETHNIC = "RACE.ASIAN",
                RACEOTH = null,
                SEX = "M"
            };
            return dm;
        }

        public DM PosteCRFDemography(DM dm)
        {
            return dm;
        }
    }
}
