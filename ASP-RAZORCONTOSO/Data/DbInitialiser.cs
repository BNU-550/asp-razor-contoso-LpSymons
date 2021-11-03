using ASP_RAZORCONTOSO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZORCONTOSO.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Lee",LastName="May",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Jamie",LastName="Branigan",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Phil",LastName="Perry",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Dave",LastName="Holmes",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Sam",LastName="Brown",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Jordan",LastName="Morse",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Rachel",LastName="Richards",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Daisy",LastName="Martos",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Software Engineering",Credits=3},
                new Course{CourseID=4022,Title="Game Deisgn",Credits=3},
                new Course{CourseID=4041,Title="Sports Performance",Credits=3},
                new Course{CourseID=1045,Title="Cyber Security",Credits=4},
                new Course{CourseID=3141,Title="Networking",Credits=4},
                new Course{CourseID=2021,Title="Nursing",Credits=3},
                new Course{CourseID=2042,Title="Aviation",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
