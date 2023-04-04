using AspNetMvcİntro.Entities;
using System.Collections.Generic;

namespace AspNetMvcİntro
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employee { get; set; }
        public List<string> Cities { get; set; }
    }
}