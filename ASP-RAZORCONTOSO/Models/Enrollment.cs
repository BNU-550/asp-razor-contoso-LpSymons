using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZORCONTOSO.Models
{
    
    public enum Grades
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Nullable<Grades> Grade { get; set; }

        // Navigation proerties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

