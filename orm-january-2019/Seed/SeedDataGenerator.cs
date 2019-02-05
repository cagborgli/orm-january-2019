using System;
using System.Collections.Generic;
using System.Linq;
using orm_january_2019.Data;
using orm_january_2019.Data.Entity;
using orm_january_2019.Util;

namespace orm_january_2019.Seed
{
    public class SeedDataGenerator
    {
        public static void GenerateData()
        {
            using (var context = new SchoolContext())
            {
                Console.WriteLine("Seeding majors");
                GenerateMajors(context);
                
                Console.WriteLine("Seeding students");
                GenerateStudents(context, 200);
            }
        }
        
        public static void GenerateMajors(SchoolContext context)
        {
            List<Major> majors = new List<Major>
            {
                new Major
                {
                    MajorText = "Computer Science"
                },
                new Major
                {
                    MajorText = "Biology"
                },
                new Major
                {
                    MajorText = "Finance"
                },
                new Major
                {
                    MajorText = "Math"
                },
                new Major
                {
                    MajorText = "Economics"
                }
            };

            context.Major.AddRange(majors);
            context.SaveChanges();
        }
        
        public static void GenerateStudents(SchoolContext context, int numOfStudents)
        {
            List<Major> majors = context.Major.ToList();
            List<Student> students = new List<Student>();
            
            for (var i = 0; i < numOfStudents; ++i)
            {
                var firstName = Generate.GenerateName(Generate.GenerateInt(4, 10));
                var lastName = Generate.GenerateName(Generate.GenerateInt(6, 12));

                var major = majors.OrderBy(s => Guid.NewGuid()).First();
                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Major = major,
                    Age = Generate.GenerateInt(18, 60),
                    Gpa = Generate.GenerateDouble(1.5, 4.5)
                };
                
                students.Add(student);
                Console.WriteLine(
                    $"Generating {firstName} {lastName} Major: {major.MajorText}, GPA: {student.Gpa}, Age: {student.Age}");
            } 
            
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}