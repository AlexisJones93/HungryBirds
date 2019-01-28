using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Models
{
    public class Meals
    {
        public int MealsId { get; set; }
        public int Week { get; set; }
        public int Dayofweek { get; set; }
        public string MealName { get; set; }
        public string Colour { get; set; }
        public int Cost { get; set; }
        public bool Selected { get; set; }
    }
}
