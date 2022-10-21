using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<StudentSubject> StudentSubject { get; set; }

        public SchoolContext()
        {

        }

        public SchoolContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(Configuration.ConfigurationString);
            }
            base.OnConfiguring(optionBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubject>().HasKey(x => new { x.StudentId, x.SubjectId });
        }
    }
}
