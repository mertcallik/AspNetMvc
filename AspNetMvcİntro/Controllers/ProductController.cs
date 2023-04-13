using System.Collections.Generic;
using AspNetMvcİntro.Entities;
using AspNetMvcİntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcİntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Add()
        {
            var productAddViewModel = new ProductAddViewModel
            {
                Product = new Product(),
                Store = new List<SelectListItem>
                {
                    new SelectListItem{Text = "İstanbul Başakşehir",Value = "1"},
                    new SelectListItem{Text = "İstanbul Kagıthane",Value = "2"},
                    new SelectListItem{Text = "İstanbul Kadıköy",Value = "3"},

                }



            };
            return View(productAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            return View();
        }

    }
}
