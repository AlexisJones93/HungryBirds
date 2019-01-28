using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HungryBirds.Data;
using HungryBirds.Models;
using HungryBirds.DatabaseModel;

namespace HungryBirds.Pages.Students
{
    public class CreateModel : DatabaseModel0
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public CreateModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateStudentNameDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}