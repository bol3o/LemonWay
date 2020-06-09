using Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Mvc;

namespace Consumer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult CallFibonacci(int value)
        //{
        //    try
        //    {
        //        GetServices.Service_Fibonacci service_Fibonacci = new GetServices.Service_Fibonacci();
        //        //GetServices.BigInteger res = service_Fibonacci.GetFibonacciValue(value);
        //        string res = service_Fibonacci.GetFibonacciValue(value).ToString();
        //        //BigInteger result = service_Fibonacci.GetFibonacciValue(value);

        //        //Mapper.CreateMap<GetServices.BigInteger, BigInteger>();
        //        //Mapper.Map<externalServices.Data.TestPerson>(testPerson);

        //        return Json(new { isValid = "Success", message = $"Le resultat est pour la saisie {value} est : {res}" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { isValid = "Error", message = ex });
        //    }
        //}

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CallXmlToJson(string value)
        {
            try
            {
                GetServices.Service_Fibonacci service_Fibonacci = new GetServices.Service_Fibonacci();
                var result = service_Fibonacci.XmlToJson(value);

                return Json(new { message = result });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex });
            }
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CallFibonacci(int value)
        {
            try
            {
                GetServices.Service_Fibonacci service_Fibonacci = new GetServices.Service_Fibonacci();
                var result = service_Fibonacci.Fibonacci(value);

                //return Json(new { isValid = "Success", message = result });
                return Json(new { message = $"Le resultat pour le montant saisie \"{value}\" est de : {result}" });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex });
            }
        }
    }
}