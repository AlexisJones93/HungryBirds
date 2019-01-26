using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.MealChoice
{
    public class DeleteModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public DeleteModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meals Meals { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meals = await _context.Meals.FirstOrDefaultAsync(m => m.MealsId == id);

            if (Meals == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meals = await _context.Meals.FindAsync(id);

            if (Meals != null)
            {
                _context.Meals.Remove(Meals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
