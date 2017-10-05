using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int courseID { get; set; }
        public virtual Course course { get; set; }
        public int deptID { get; set; }
        public virtual Department department { get; set; }
    }

    public class Instructor
    {
    }

    public class Course
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Instructor> instructors { get; set; }
    }

    public class Department
    {
    }
}