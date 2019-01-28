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

       public int MondayId { get; set; }

        public int TuesdayId { get; set; }
        public int WednesdayId { get; set; }
        public int ThuesdayId { get; set; }
        public int FridayId { get; set; }


        public int StudentId { get; set; }
        

    }
}