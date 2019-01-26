using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.MealChoice
{
    public class EditModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public EditModel(HungryBirds.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Meals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealsExists(Meals.MealsId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MealsExists(int id)
        {
            return _context.Meals.Any(e => e.MealsId == id);
        }
    }
}
