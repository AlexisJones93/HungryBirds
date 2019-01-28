using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class Selection
    {
        public DateTime Date { get; set; }
        public int SelectionId { get; set; }
        public int MealId { get; set; }
        public int StudentId { get; set; }
        
    }

}
