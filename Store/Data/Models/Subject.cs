using Store.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        public SubjectType SubjectType { get; set; }

        public double AverageGrade { get; set; }

        [Required]
        public DataType ReceivedOn { get; set; }

        public ICollection<StudentSubject> StudentSubjectcs { get; set; } = new HashSet<StudentSubject>();
    }
}
