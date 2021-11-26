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
    public class IndexModel : PageModel
    {
        private readonly ASP_RAZORCONTOSO.Data.ApplicationDbContext _context;

        public IndexModel(ASP_RAZORCONTOSO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
