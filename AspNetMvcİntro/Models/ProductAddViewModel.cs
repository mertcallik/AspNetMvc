using System.Collections.Generic;
using AspNetMvcİntro.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcİntro.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set;}
        public List<SelectListItem> Store { get; set; }
    }
}