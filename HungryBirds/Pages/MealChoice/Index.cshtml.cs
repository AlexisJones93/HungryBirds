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
    public class IndexModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public IndexModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Meals> Meals { get;set; }

        public async Task OnGetAsync()
        {
            Meals = await _context.Meals.ToListAsync();
        }
    }
}
