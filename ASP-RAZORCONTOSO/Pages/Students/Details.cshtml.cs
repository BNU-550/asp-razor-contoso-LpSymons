using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RAZORCONTOSO.Data;
using ASP_RAZORCONTOSO.Models;

namespace ASP_RAZORCONTOSO.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_RAZORCONTOSO.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_RAZORCONTOSO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
        .Include(s => s.Enrollments)
        .ThenInclude(e => e.Course)
        .AsNoTracking()
        .FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
