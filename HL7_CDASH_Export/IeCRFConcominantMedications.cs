using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HL7_CDASH_Export.Domain.CM;

namespace HL7_CDASH_Export
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IeCRFConcominantMedications" in both code and config file together.
    [ServiceContract]
    public interface IeCRFConcominantMedications
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GeteCRFConcominantMedications")]
        CM GeteCRFConcominantMedications();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PosteCRFConcominantMedications")]
        CM PosteCRFConcominantMedications(CM cm);
    }
}
