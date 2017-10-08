using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        public int InstructorID { get; set; }

        public ICollection<Student> Students { get; set; }
        [ForeignKey("InstructorID")]
        public ICollection<Instructor> Instructors { get; set; }
    }
}