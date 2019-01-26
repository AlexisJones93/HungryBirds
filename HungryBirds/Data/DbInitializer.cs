using HungryBirds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryBirds.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",DateOfBirth= "May", School= "Bucks", YearGroup= "Three", Class = "Miss Smith", Allergies="Gluten"},
            new Student{FirstMidName="Carson",LastName="Alexander",DateOfBirth= "May", School= "Bucks", YearGroup= "Three", Class = "Miss Smith", Allergies="Gluten"},

            };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            
            if (context.Parent.Any())
            {
                return;   
            }

            var Parents = new Parent[]
            {
            new Parent{FirstName="Alexis",LastName="Jones",Address= "3 School way, SL2 9LJ", Email= "21406612@bucks.ac.uk"},
          

            };
            foreach (Parent s in Parents)
            {
                context.Parent.Add(s);
            }
            context.SaveChanges();
        }
    }


    
    
}
