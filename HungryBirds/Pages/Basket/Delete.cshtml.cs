using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.Basket
{
    public class DeleteModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public DeleteModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Selection Selection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Selection = await _context.Selection.FirstOrDefaultAsync(m => m.SelectionId == id);

            if (Selection == null)
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

            Selection = await _context.Selection.FindAsync(id);

            if (Selection != null)
            {
                _context.Selection.Remove(Selection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
