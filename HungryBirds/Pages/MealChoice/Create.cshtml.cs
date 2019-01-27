using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.MealChoice
{
    public class CreateModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public CreateModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        
        [BindProperty]
        public Meals Meals { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meals.Add(Meals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}