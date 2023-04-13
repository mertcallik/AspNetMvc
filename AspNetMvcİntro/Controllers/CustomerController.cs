using AspNetMvcİntro.Entities;
using AspNetMvcİntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcİntro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Add()
        {
            var customerAddViewModel = new CustomerAddViewModel
            {
                Customer = new Customer()
            };
            return View(customerAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            return View();
        }
    }
}
