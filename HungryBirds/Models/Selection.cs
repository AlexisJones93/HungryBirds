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

        [ForeignKey("MealId")]
        public int MealId { get; set; }

        [ForeignKey("AccountId")]
        public int AccountId { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }


        
    }
}