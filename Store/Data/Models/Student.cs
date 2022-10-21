using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public ICollection<StudentSubject> StudentSubjectcs { get; set; } = new HashSet<StudentSubject>();
    }
}
