using AspNetMvcİntro.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcİntro.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set;}
        public List<SelectListItem> Cities { get; set; }
    }
}