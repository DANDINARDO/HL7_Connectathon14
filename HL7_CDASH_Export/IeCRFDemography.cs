using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HL7_CDASH_Export.Domain.DM;

namespace HL7_CDASH_Export
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IeCRF_Demography" in both code and config file together.
    [ServiceContract]
    public interface IeCRFDemography
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GeteCRFDemography/{Id}")]
        DM GeteCRFDemography(string Id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PosteCRFDemography")]
        DM PosteCRFDemography(DM dm);
    }
}
