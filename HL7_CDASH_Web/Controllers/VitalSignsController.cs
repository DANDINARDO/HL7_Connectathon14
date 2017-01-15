using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HL7_CDASH_Web.Models;
using Newtonsoft.Json;

namespace HL7_CDASH_Web.Controllers
{
    public class VitalSignsController : Controller
    {
        // GET: VitalSigns
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostVitalSigns(VitalSignsViewModels vsV)
        {
            try
            {
                string json = JsonConvert.SerializeObject(vsV, Newtonsoft.Json.Formatting.Indented);
                bool isSuccess = false;
                ServiceConnector.ServiceConnector serviceConnector = new ServiceConnector.ServiceConnector();
                vsV.Results = serviceConnector.CallService(@"https://localhost:44301/eCRFVitalSigns.svc/PosteCRFVitalSigns", json, out isSuccess);
                return View("Index", vsV);
            }
            catch (Exception ex)
            {
                vsV.Results = (String.Format(@"Error:{0}", ex.Message));
                return View("Index", vsV);
            }
        }
    }
}