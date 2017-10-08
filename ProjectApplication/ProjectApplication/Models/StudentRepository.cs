using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    public class StudentRepository
    {
        public List<Course> ListOfCourses()
        {
            ManagementContext ManagementContext = new ManagementContext();
            return ManagementContext.Courses.ToList();
        }
        public List<Student> ListOfStudents()
        {
            ManagementContext ManagementContext = new ManagementContext();
            return ManagementContext.Students.ToList();
        }
        //public Instructor Advisor()
        //{
        //    ManagementContext StudentContext = new ManagementContext();
        //    return StudentContext.Instructors.SingleOrDefault();
        //}
    }
}