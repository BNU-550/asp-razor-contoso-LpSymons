using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZORCONTOSO.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [StringLength(256)]
        public string UserID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

    }
}
