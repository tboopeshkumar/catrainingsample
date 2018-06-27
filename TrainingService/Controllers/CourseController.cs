using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingService.Data;
using TrainingService.Models;

namespace TrainingService.Controllers
{
    namespace ContosoUniversity.Controllers
    {
        public class CoursesController : Controller
        {
            private readonly TrainingContext _context;

            public CoursesController(TrainingContext context)
            {
                _context = context;
            }

            // GET: Courses
            public  async Task<IActionResult> Index()
            {
                var courses = _context.Courses
                    .Include(c => c.Enrollments)
                    .AsNoTracking();
                return  Json(await  courses.ToListAsync());
            }

            // GET: Courses/Details/5
            public async Task<IActionResult> DetailsAsync(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var course = await _context.Courses
                    .Include(c => c.Enrollments)
                    .AsNoTracking()
                    .SingleOrDefaultAsync(m => m.CourseID == id);
                if (course == null)
                {
                    return NotFound();
                }

                return Json(course);
            }

           

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("CourseID,Credits,Title")] Course course)
            {
                _context.Add(course);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                
               
                
            }

           
        }
    }
}