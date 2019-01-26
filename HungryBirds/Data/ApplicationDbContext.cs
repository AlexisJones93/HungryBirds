using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Models;

namespace HungryBirds.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // test
        }
        public DbSet<HungryBirds.Models.Meals> Meals { get; set; }
        public DbSet<HungryBirds.Models.Student> Student { get; set; }
        public DbSet<HungryBirds.Models.Parent> Parent { get; set; }
        public DbSet<HungryBirds.Models.Selection> Selection { get; set; }
        
    }
}
