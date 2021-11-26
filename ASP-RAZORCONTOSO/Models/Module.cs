using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZORCONTOSO.Models
{
    public class Module
    {
        [Key, StringLength(6), Display(Name =  "Code")]
        [RegularExpression("[A-Z]{2}[0-9]{3}")]
        public string ModuleID { get; set; }

        [StringLength(30), Required, MinLength(10)]
        public string Title { get; set; }

        public int Credit { get; set; } = 15;

        [StringLength(255)]
        public string Description { get; set; }

        public string FullTitle
        {
            get { return ModuleID + ": " + Title; }
        }

        //Navigation Properties

        public virtual ICollection<Course> Courses { get; set; }
    }
}
