using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Models;

namespace TrainingService.Data
{
    public static class SampleData
    {

        public static IList<Course> courses = new List<Course>();
        public static IList<Course> Courses
        {
            get
            {
                if (courses.Count == 0)
                {
                    var coursesLocal = new Course[]
            {
                new Course {CourseID = 1050, Title = ".NET",      Credits = 3,

                },
                new Course {CourseID = 4022, Title = "Java", Credits = 3,

                },
                new Course {CourseID = 4041, Title = "Python", Credits = 3,

                },
                new Course {CourseID = 1045, Title = "Data Science",       Credits = 4,

                },

            };
                    courses = new List<Course>(coursesLocal);   
                }
                
               
                    return courses;

            }
        }

        public static IList<Student> Students
        {

            get
            {
                var students = new Student[]
          {
                new Student { FirstName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Student { FirstName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Nino",     LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") }
          };
                return students;

            }
        }

        public static IList<Enrollment> Enrollments
        {
            get
            {
                var enrollments = new Enrollment[]
            {
                new Enrollment {
                    Student = Students.Single(s => s.LastName == "Alexander"),
                    Course = Courses.Single(c => c.Title == ".NET" ),
                    Grade = Grade.A
                },
                    new Enrollment {
                    Student = Students.Single(s => s.LastName == "Alexander"),
                    Course = Courses.Single(c => c.Title == "Java" ),
                    Grade = Grade.C
                    },
                    new Enrollment {
                    Student = Students.Single(s => s.LastName == "Alexander"),
                    Course = Courses.Single(c => c.Title == "Python" ),
                    Grade = Grade.B
                    },
                    new Enrollment {
                        Student = Students.Single(s => s.LastName == "Alonso"),
                    Course = Courses.Single(c => c.Title == ".NET" ),
                    Grade = Grade.B
                    },
                    new Enrollment {
                        Student = Students.Single(s => s.LastName == "Alonso"),
                    Course = Courses.Single(c => c.Title == "Java" ),
                    Grade = Grade.B
                    },
                   

            };
                return enrollments;
            }
        }
    }
}
