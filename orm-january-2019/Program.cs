using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using orm_january_2019.Data;

namespace orm_january_2019
{
    class Program
    {
        static void Main(string[] args)
        {

//             Seed data generated in database
//            Seed.SeedDataGenerator.GenerateData();

            using (var context = new SchoolContext())
            {
                var students = context.Students;

                var orderedStudents = 
                    from s in students.Include(s => s.Major)
                    orderby s.Major.MajorText, s.Gpa descending 
                    select s;

                Console.WriteLine(orderedStudents.First().ToString());
                
            }
        }
    }
}