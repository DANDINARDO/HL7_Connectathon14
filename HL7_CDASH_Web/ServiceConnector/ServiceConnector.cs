using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace HL7_CDASH_Web.ServiceConnector
{
    public class ServiceConnector
    {
        public string CallService(string theurl, string datajson, out bool isSuccess)
        {
            isSuccess = true;
            try
            {
                // Web service URL
                string theURL = theurl;

                // The message to send to the web service
                string theMessage = datajson;

                // Create web request to web service URL
                var webReq = (HttpWebRequest)WebRequest.Create(theURL);

                // POST to the service
                webReq.Method = "POST";
                webReq.ContentType = "application/json";
                webReq.Accept = "application/json";

                // Get the message to send
                byte[] buffer = Encoding.UTF8.GetBytes(theMessage);
                webReq.ContentLength = buffer.Length;

                // Call the web service and get a response
                var reqStream = webReq.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();
                HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();

                // Will hold the response from the web server
                String theResponseString = "";

                // Read the response from the web service to the response string
                using (Stream stream = webResp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    theResponseString = reader.ReadToEnd();
                }

                // Close the response
                webResp.Close();

                return theResponseString;

            }
            catch (Exception e)
            {
                isSuccess = false;
                return "";
            }

        }
    }
}