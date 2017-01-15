using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HL7_CDASH_Web.Models;
using Newtonsoft.Json;

namespace HL7_CDASH_Web.Controllers
{
    public class DemographyController : Controller
    {
        // GET: Demography
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostDemography(DemographyViewModels dmV)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dmV, Newtonsoft.Json.Formatting.Indented);
                bool isSuccess = false;
                ServiceConnector.ServiceConnector serviceConnector = new ServiceConnector.ServiceConnector();
                dmV.Results = serviceConnector.CallService(@"https://localhost:44301/eCRFDemography.svc/PosteCRFDemography", json, out isSuccess);
                return View("Index", dmV);
            }
            catch (Exception ex)
            {
                dmV.Results = (String.Format(@"Error:{0}", ex.Message));
                return View("Index", dmV);
            }
        }
    }
}