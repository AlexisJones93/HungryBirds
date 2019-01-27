using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Models;
using HungryBirds.Data;
using System;

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
            Meals= await _context.Meals.ToListAsync();
        }
       

       
    }
}
