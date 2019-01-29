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

        [Display(Name = "Monday")]
        public String MondayId { get; set; }
        [Display(Name = "Tuesday")]
        public String TuesdayId { get; set; }
        [Display(Name = "Wednesday")]
        public String WednesdayId { get; set; }
        [Display(Name = "Thursday")]
        public String ThuesdayId { get; set; }
        [Display(Name = "Friday")]
        public String FridayId { get; set; }

        [Display (Name= "Student Name")]
        public String StudentId { get; set; }
        

    }
}