using milestone_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace milestone_1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{Name="Bayan",SurName="Akhmetova",Age=21,EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{Name="Tokzhan",SurName="Bazarbayeva",Age=21,EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{Name="Anel",SurName="Erlankyzy",Age=20,EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{Name="Gaukhar",SurName="Islamova",Age=20,EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{Name="Arina",SurName="Issakina",Age=21,EnrollmentDate=DateTime.Parse("2017-09-01")}            
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var teachers = new Teacher[]
            {
            new Teacher{Name="Galymzhan",SurName="Alin",CourseID=101},
            new Teacher{Name="Aidos",SurName="Sarsembayev",CourseID=102},
            new Teacher{Name="Ergali",SurName="Dauletbek",CourseID=103},
            new Teacher{Name="Shadi",SurName="Aljawarneh",CourseID=104},
            new Teacher{Name="Almas",SurName="Sabitov",CourseID=105},
            new Teacher{Name="Makpal",SurName="Malgazhdarova",CourseID=106}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=101,Title="Managing technical people",Credits=4},
            new Course{CourseID=102,Title="Research Fundamentals",Credits=1},
            new Course{CourseID=103,Title="MIcrosoft .NET Framework: ASP.NET",Credits=6},
            new Course{CourseID=104,Title="MobIle technologIes and applIcatIons",Credits=6},
            new Course{CourseID=105,Title="Philosophy",Credits=4},
            new Course{CourseID=106,Title="Ecology and Industrial Safety",Credits=3}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=101,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=102,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=103,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=104,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=105,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=106,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=101},
            new Enrollment{StudentID=4,CourseID=102},
            new Enrollment{StudentID=4,CourseID=103,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=104,Grade=Grade.C},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
