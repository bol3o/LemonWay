using Model.ModelXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace SOAPWebService
{
    /// <summary>
    /// Description résumée de Service_Fibonacci
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Fibonacci : System.Web.Services.WebService
    {
        [WebMethod]
        //[ValidateInput(false)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Fibonacci(int n)
        {
            try
            {
                var bigInteger = HandleFibonacci.Fibonacci(n);
                string toReturn = bigInteger.ToString();

                return toReturn;
            }
            catch (Exception ex)
            {
                return "-1";
            }
        }

        [WebMethod]
        //[ValidateInput(false)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string XmlToJson(string xml)
        {
            try
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Trans));
                using (TextReader reader = new StringReader(xml))
                {
                    Trans toJson = (Trans)serializer.Deserialize(reader);

                    return new JavaScriptSerializer().Serialize(toJson);
                }
            }
            catch (Exception ex)
            {
                return "Bad Xml format";
            }
        }
    }
}
