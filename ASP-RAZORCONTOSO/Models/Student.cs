using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RAZORCONTOSO.Models
{
    public class Student : Person
    {
        [StringLength(8), RegularExpression("[1-9]{8}")]
        public string UniversityID { get; set; }

        [DisplayName("Enrol Date"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public int EnrollmentID { get; set; }
        
        //Relationship or navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
       
    }
    }

