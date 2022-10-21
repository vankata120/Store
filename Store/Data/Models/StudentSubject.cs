using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required]
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
