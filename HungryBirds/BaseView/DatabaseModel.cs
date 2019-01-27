using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HungryBirds.Data;

namespace HungryBirds.DatabaseModel
{
    public class DatabaseModel:PageModel
    { 
        public SelectList StudentSL { get; set; }
    
        public void PopulateStudentNameDropDownList(ApplicationDbContext _context, object selectedStudent = null)
        {
            var StudentQuery = from d in _context.Student
                                 orderby d.FirstMidName
                                 select d;
            StudentSL = new SelectList(StudentQuery.AsNoTracking(), "StudentId", "FirstMidName", selectedStudent);
        }

        


    }
}
