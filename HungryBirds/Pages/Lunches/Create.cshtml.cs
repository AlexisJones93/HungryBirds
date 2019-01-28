using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HungryBirds.Data;
using HungryBirds.Models;
using HungryBirds.DatabaseModel;

namespace HungryBirds.Pages.Lunches
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
            PopMondayMealDDP(_context);
            return Page();
        }

        [BindProperty]
        public Selection Selection { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Selection.Add(Selection);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}