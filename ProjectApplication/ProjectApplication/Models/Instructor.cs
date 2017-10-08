using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        [Required]
        public string InstructorName { get; set; }
        public string Designation { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}