using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.TopUp
{
    public class DeleteModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public DeleteModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Parent Parent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parent = await _context.Parent.FirstOrDefaultAsync(m => m.ParentId == id);

            if (Parent == null)
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

            Parent = await _context.Parent.FindAsync(id);

            if (Parent != null)
            {
                _context.Parent.Remove(Parent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
