using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP_RAZORCONTOSO.Models
{

    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(8)]
        [RegularExpression("[A-Z]{2}[0-9]{1}[A-Z]{3}[0-9]{1}!")]
        public string CourseID { get; set; }



        [StringLength(30), Required, MinLength(10)]
        public string Title { get; set; }

        public string FullTitle
        {
            get { return "BSc (Hons) " + Title; }
        }

        public int Credits { get; set; }

        // Navigation Properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }

    }
