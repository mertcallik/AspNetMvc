using System;
using System.Collections.Generic;
using System.Linq;
using AspNetMvcİntro.Entities;
using AspNetMvcİntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace AspNetMvcİntro.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Add()
        {
            
            var cityAddViewModel = new CityAddViewModel
            {
                Cities =new Cities()
            };

            return View(cityAddViewModel);
        }

        [HttpPost]

        public JsonResult Addo(Cities cities)
        {
            
            Console.WriteLine("Kullanicinin girdiği değerler {0},{1}",cities.CityId,cities.CityName);
            return Json(cities);
        }
    }
}
