using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    //public class Student
    //{
    //    [Key]
    //    public int StudentID { get; set; }
    //    [Required]
    //    public string FirstName { get; set; }
    //    [Required]
    //    public string LastName { get; set; }
    //    public string PhoneNumber { get; set; }
    //    [Required]
    //    public string EmailAddress { get; set; }
    //    public int CourseID { get; set; }
    //    [ForeignKey("CourseID")]
    //    public virtual ICollection<Course> Courses { get; set; }
    //    public int DepartmentID { get; set; }
    //    [ForeignKey("DepartmentID")]
    //    public virtual Department Department { get; set; }
    //}

    //public class Instructor
    //{
    //    [Key]
    //    public int InstructorID { get; set; }
    //    [Required]
    //    public string InstructorName { get; set; }
    //    public string Designation { get; set; }
    //    public ICollection<Student> Students { get; set; }
    //    public ICollection<Course> Courses { get; set; }
    //}

    //public class Course
    //{
    //    [Key]
    //    public int CourseID { get; set; }
    //    [Required]
    //    public string CourseName { get; set; }
    //    public int InstructorID { get; set; }

    //    public ICollection<Student> Students { get; set; }
    //    [ForeignKey("InstructorID")]
    //    public ICollection<Instructor> Instructors { get; set; }
    //}

    //public class Department
    //{
    //    [Key]
    //    public int DepartmentID { get; set; }
    //    [Required]
    //    public string DeptName { get; set; }
    //    public ICollection<Student> Students { get; set; }
    //    public ICollection<Instructor> Instructors { get; set; }
    //    public ICollection<Course> Courses { get; set; }
    //}
}