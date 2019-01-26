using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class School
    { 
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string MealSelection { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
