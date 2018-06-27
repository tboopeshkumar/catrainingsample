using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingService.Data;
using TrainingService.Models;

namespace TrainingService.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
      


        [HttpGet("[action]")]
        public IEnumerable<Course> Courses()
        {
           return SampleData.Courses;
        }

        [HttpPost("[action]")]
        public bool AddCourse(Course course)
        {
            SampleData.courses.Add(course);
            return true;
        }

        [HttpGet("[action]")]
        public IEnumerable<Student> Students()
        {
           
            return SampleData.Students;

        }

        [HttpGet("[action]")]
        public IEnumerable<Enrollment> Entrollments()
        {
            return SampleData.Enrollments;

        }






    }
}
