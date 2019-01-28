using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HungryBirds.Data;

namespace HungryBirds.DatabaseModel
{
    public class DatabaseModel0 : PageModel
    { 
        public SelectList StudentSL { get; set; }
    public SelectList MondayMeal { get; set; }

        public void PopulateStudentNameDropDownList(ApplicationDbContext _context, object selectedStudent = null)
        {
            var StudentQuery = from d in _context.Student
                                 orderby d.FirstMidName
                                 select d;
            StudentSL = new SelectList(StudentQuery.AsNoTracking(), "StudentID", "FirstMidName", selectedStudent);
        }
        public void PopMondayMealDDP(ApplicationDbContext _context, object SelectedMonday = null)
        {
            var MondayQyer = from d in _context.Meals
                             orderby d.MealName
                             select d;
            MondayMeal = new SelectList(MondayQyer.AsNoTracking(), "MealsId", "MealName", SelectedMonday);


        }
        


    }
}
