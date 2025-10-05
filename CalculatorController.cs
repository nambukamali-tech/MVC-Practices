
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculatorMVC.Models;

namespace CalculatorMVC.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: calculator
        [HttpGet]
        public ActionResult Index()
        {
            return View(new CalculatorModel());
        }
        [HttpPost]
        public ActionResult Index(CalculatorModel model)
        {
            double result = 0;
            if (model.operation == "Add")
                result = model.Number1 + model.Number2;
            else if (model.operation == "Subtract")
                result = model.Number1 - model.Number2;
            else if (model.operation == "Multiply")
                result = model.Number1 * model.Number2;
            else if(model.operation == "Division")
            {
                if(model.Number2 != 0)
                {
                    result = model.Number1 / model.Number2;
                }
            }
            model.result = result;
            return View(model);
        }
    }
}