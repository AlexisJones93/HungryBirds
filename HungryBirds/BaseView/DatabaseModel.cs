using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HungryBirds.Data;

namespace HungryBirds.DatabaseModel //test
{
    public class DatabaseModel0 : PageModel
    { 
        public SelectList StudentSL { get; set; }
    public SelectList MondayMeal { get; set; }
        public SelectList AccountSL { get; set; }

        public void PopulateStudentNameDropDownList(ApplicationDbContext _context, object selectedStudent = null)
        {
            var StudentQuery = from d in _context.Student
                                 orderby d.FirstMidName
                                 select d;
            StudentSL = new SelectList(StudentQuery.AsNoTracking(), "FirstMidName", "FirstMidName", selectedStudent);
        }
        public void PopMondayMealDDP(ApplicationDbContext _context, object SelectedMonday = null)
        {
            var MondayQyer = from d in _context.Meals
                             orderby d.MealName
                             select d;
            MondayMeal = new SelectList(MondayQyer.AsNoTracking(), "MealName", "MealName", SelectedMonday);


        }
        public void PopulateAccountNameDropDownList(ApplicationDbContext _context, object selectedAccount = null)
        {
            var AccountQuery = from d in _context.Parent
                               orderby d.FirstName
                               select d;
            AccountSL = new SelectList(AccountQuery.AsNoTracking(), "FirstName", "FirstName", selectedAccount);
        }


    }
}
