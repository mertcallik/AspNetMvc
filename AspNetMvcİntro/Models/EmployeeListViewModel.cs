using AspNetMvcİntro.Entities;
using System.Collections.Generic;

namespace AspNetMvcİntro.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employee { get; set; }
        public List<string> Cities { get; set; }
    }
}