using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HL7_CDASH_Export.Domain.VS;

namespace HL7_CDASH_Export
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IeCRFVitalSigns" in both code and config file together.
    [ServiceContract]
    public interface IeCRFVitalSigns
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GeteCRFVitalSigns")]
        VS GeteCRFVitalSigns();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PosteCRFVitalSigns")]
        VS PosteCRFVitalSigns(VS vs);
    }
}
