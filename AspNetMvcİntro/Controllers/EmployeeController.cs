using Microsoft.AspNetCore.Mvc;
using AspNetMvcİntro.Entities;
using AspNetMvcİntro.Models;
namespace AspNetMvcİntro.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee()
            };
              

            return View(employeeAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
    }
}
