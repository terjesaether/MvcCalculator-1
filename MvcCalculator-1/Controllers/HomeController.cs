using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCalculator_1.Models;

namespace MvcCalculator_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(FormValues model)
        {
            Calculator calc = new Calculator();
            
            string message = "";
            string opText = "";

            // Verdien av radio-knappene (InputValues.Operator) blir sendt til Calculator.Operations-metoden, og bestemmer hvilken regneoperasjon som blir gjennomført
            // Verdien av de to input-boksene blir sendt 
            double result = calc.Operations(model.Operator, model.Input1, model.Input2, out message, out opText);
            
            ViewBag.Result = result;
            ViewBag.Message = message;
            ViewBag.OpText = opText;
            
            ViewBag.Input1 = model.Input1;
            ViewBag.Input2 = model.Input2;
            
            return View();
        }

        public ActionResult QueryLinkTest(string id, string seriesID, string episodeID )
        {
            ViewBag.Id = id;
            ViewBag.Serie = seriesID;
            ViewBag.Episode = episodeID;
            return View();
        }

        

    }
}