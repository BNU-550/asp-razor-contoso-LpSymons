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

                AddPeople(context);

                AddTutors(context);

                AddCourses(context);

                AddEnrollments(context);

                AddModules(context);
            }

        private static void AddPeople(ApplicationDbContext context)
        {

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Students.Any())
            {
                return; // DB has been seeded
            }
            var students = new Student[]
            {
                new Student
                {
                    FirstName="Lee",LastName="May",
                    UniversityID="21713170", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Jamie",LastName="Branigan",
                    UniversityID="21713171", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Phil",LastName="Perry",
                    UniversityID="21713172", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Dave",LastName="Holmes",
                    UniversityID="21713173", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Sam",LastName="Brown",
                    UniversityID="21713174", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Jordan",LastName="Morse",
                    UniversityID="21713175", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Rachel",LastName="Richards",
                    UniversityID="21713176", EnrollmentDate=DateTime.Parse("2021-09-01")
                },
                new Student
                {
                    FirstName="Daisy",LastName="Martos",
                    UniversityID="21713177", EnrollmentDate=DateTime.Parse("2021-09-01")
                },

            };

            context.Students.AddRange(students);
            context.SaveChanges();

            

        }

        private static void AddTutors(ApplicationDbContext context)
        {
            if (context.Tutors.Any())
            {
                return; // DB has been seeded
            }

            var tutors = new Tutor[]
            {
                new Tutor
                {
                    FirstName="Derek", LastName="Peacock",
                    Degree = "BSc (Hons) Soft Eng",
                    Salary = 99000
                },
                new Tutor
                {
                    FirstName="Mike", LastName="Everette",
                    Degree = "BSc (Hons) Soft Eng",
                    Salary = 99000
                }
            };

            context.Tutors.AddRange(tutors);
            context.SaveChanges();
        }




        private static void AddCourses(ApplicationDbContext context)
            {
                if(context.Courses.Any())
                {
                    return; // DB has been seeded
                }

            Module co550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web Applications",
            };

            Module co588 = new Module
            {
                ModuleID = "CO588",
                Title = "Database Design",
            };

            Module co567 = new Module
            {
                ModuleID = "CO567",
                Title = "OOA&D",
            };

            Module co566 = new Module
            {
                ModuleID = "CO566",
                Title = "OO Programming",
            };

            var modules = new Module[]
            {
                co550, co566, co567, co588
            };

            context.Modules.AddRange(modules);
            context.SaveChanges(true);

            if(context.Courses.Any())
            {
                return; // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "BT1CTG1",
                    Title = "Computing",
                    Modules = new List<Module>{ co550, co566, co567, co588 }
                },
                new Course
                {
                    CourseID = "BT1CWD1",
                    Title = "Computing and Web",
                    Modules = new List<Module>{ co550, co566, co567, co588 }
                },
                new Course { CourseID = "BB1DSC1", Title = "Data Science"},
                new Course { CourseID = "BT1SFT1", Title = "Software Engineering"},
                new Course { CourseID = "BB1ARI1", Title = "Artifical Intelligence"},
                new Course { CourseID = "MT1CYS1", Title = "Cyber Security"},
                new Course { CourseID = "BT1GDV1", Title = "Games Devlopment"}
            };


            context.Courses.AddRange(courses);
            context.SaveChanges();
            }

            private static void AddEnrollments(ApplicationDbContext context)
            {
                if(context.Enrollments.Any())
                {
                    return; // DB has been seeded
                }
            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID="BT1CTG1",Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID="BT1CWD1",Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID="BB1DSC1",Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID="BT1SFT1",Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID="BB1ART1",Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID="MT1CYS1",Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID="BT1GDV1"},

            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
            }

            private static void AddModules(ApplicationDbContext context)
            {
                if(context.Modules.Any())
                {
                    return; // DB has been seeded
                }

                var modules = new Module[]
                {
                    new Module{ModuleID = "CO550", Title="Web Applications"},
                    new Module{ModuleID = "CO558", Title="Database Design"},
                    new Module{ModuleID = "CO567", Title="OOA&D "},
                    new Module{ModuleID = "CO566", Title="OO Programming"},
                };

                context.Modules.AddRange(modules);
                context.SaveChanges(true);
            }
        
    }
}
