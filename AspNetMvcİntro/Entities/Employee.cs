using System.ComponentModel;

namespace AspNetMvcİntro.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("First Namee")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
    }
}
 