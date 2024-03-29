﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Data;
using HungryBirds.Models;

namespace HungryBirds.Pages.Account
{
    public class EditModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public EditModel(HungryBirds.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Parent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParentExists(Parent.ParentId))
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

        private bool ParentExists(int id)
        {
            return _context.Parent.Any(e => e.ParentId == id);
        }
    }
}
