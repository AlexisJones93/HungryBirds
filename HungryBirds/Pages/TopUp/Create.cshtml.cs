using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.TopUp
{
    public class CreateModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public CreateModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Parent Parent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Parent.Add(Parent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}