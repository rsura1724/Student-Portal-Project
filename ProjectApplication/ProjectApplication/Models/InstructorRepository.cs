using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectApplication.Models
{
    public class InstructorRepository
    {
        public List<Student> ListOfStudents()
        {
            ManagementContext ManagementContext = new ManagementContext();
            return ManagementContext.Students.ToList();
        }

        public List<Course> ListOfCourses()
        {
            ManagementContext ManagementContext = new ManagementContext();
            return ManagementContext.Courses.ToList();
        }
    }
}