using System.Collections.Generic;
using System.Linq;
using AspNetMvcİntro.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcİntro.Controllers
{
    public class HomeController : Controller
    {


        public string Index()
        {
            return "Mertcigimmmm";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirtName = "Mert", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 2, FirtName = "Rabişş", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 3, FirtName = "Mini", LastName = "Çalık", CityId = 34 }
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara", "İzmir" };

            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities


            };
            return View(model);
        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }

        public IActionResult Index6()
        {
            return Redirect("/home/index3");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirtName = "Mert", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 2, FirtName = "Rabişş", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 3, FirtName = "Mini", LastName = "Çalık", CityId = 34 }
            };

            return Json(employees);
        }

        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirtName = "Mert", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 2, FirtName = "Rabişş", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 3, FirtName = "Mini", LastName = "Çalık", CityId = 34 }
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara", "İzmir" };

            var model = new EmployeeListViewModel()
            {
                Employee = employees,
                Cities = cities
            };

            return View(model);
        }

        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirtName = "Mert", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 2, FirtName = "Rabişş", LastName = "Çalık", CityId = 34 },
                new Employee { Id = 3, FirtName = "Mini", LastName = "Çalık", CityId = 34 }
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirtName.ToLower().Contains(key));

            return Json(result);
        }

        public ViewResult EmployeeForm()
        {
            return View();
        }

        public string RouteData(int id)
        {
            return id.ToString();
        }
    }
}
