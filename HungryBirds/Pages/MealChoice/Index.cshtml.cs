using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Models;
using HungryBirds.Data;
using System;
using System.Linq;

namespace HungryBirds.Pages.MealChoice
{
    public class IndexModel : PageModel
    {
        private readonly HungryBirds.Data.ApplicationDbContext _context;

        public IndexModel(HungryBirds.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Meals> Meals { get;set; }

        

        public async Task OnGetAsync()
        {
            IQueryable<Meals> MealQ = from s in _context.Meals
                                      select s;
            MealQ = MealQ.OrderBy(s => s.Dayofweek);
            // Meals = await _context.Meals.ToListAsync();
            // MealQ =  await MealQ.ToListAsync();
            Meals = await MealQ.ToListAsync();
        }
       

       
    }
}
