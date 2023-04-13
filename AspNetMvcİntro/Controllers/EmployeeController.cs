using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcİntro.Entities;
using AspNetMvcİntro.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcİntro.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text = "Ankara",Value = "6"},
                    new SelectListItem{Text = "İstanbul",Value = "34"},
                }
                
            };
            employeeAddViewModel.Cities.Add(new SelectListItem{Text = "Merttttt",Value = "345"});
            employeeAddViewModel.Cities.Add(new SelectListItem { Text = "ddderttttt", Value = "3425" });

            return View(employeeAddViewModel);
        }
        


        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }

    }
}
