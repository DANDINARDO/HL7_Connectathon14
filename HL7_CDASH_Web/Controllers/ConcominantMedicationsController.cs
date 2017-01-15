using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HL7_CDASH_Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace HL7_CDASH_Web.Controllers
{
    public class ConcominantMedicationsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostConcominantMedications(ConcominantMedicationsViewModels cmV)
        {
            try
            {
                string json = JsonConvert.SerializeObject(cmV, Newtonsoft.Json.Formatting.Indented);
                bool isSuccess = false;
                ServiceConnector.ServiceConnector serviceConnector = new ServiceConnector.ServiceConnector();
                cmV.Results = serviceConnector.CallService(@"https://localhost:44301/eCRFConcominantMedications.svc/PosteCRFConcominantMedications", json, out isSuccess);
                return View("Index", cmV);
            }
            catch (Exception ex)
            {
                cmV.Results = (String.Format(@"Error:{0}", ex.Message));
                return View("Index", cmV);
            }
        }

    }
}