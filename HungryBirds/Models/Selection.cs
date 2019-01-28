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
        public string MealId { get; set; }

        [ForeignKey("AccountId")]
        public string AccountId { get; set; }

    }
}