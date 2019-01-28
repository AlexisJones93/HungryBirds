using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string School { get; set; }
        public string YearGroup { get; set; }
        public string Class { get; set; }
        public string Allergies { get; set; }

        [ForeignKey("ParentId")]
        public int ParentId { get; set; }
    }
}
