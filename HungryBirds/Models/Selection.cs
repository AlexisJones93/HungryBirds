using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class Selection
    {
        [Key]
        public int SelectionId { get; set; }

       public String MondayId { get; set; }

        public String TuesdayId { get; set; }
        public String WednesdayId { get; set; }
        public String ThuesdayId { get; set; }
        public String FridayId { get; set; }

        [Display (Name= "Student Name")]
        public String StudentId { get; set; }
        

    }
}