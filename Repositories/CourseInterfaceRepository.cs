using SIS_Assignment_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public interface iCourseRepository
    {

        int AssignTeacher(Teacher teacher, Courses course);
        int UpdateCourseInfo(int CourseId, string CourseCode, string CourseName, int instructor);
        Courses DisplayCourseInfo(Courses course);
        List<Students> GetEnrollments(Courses course);
        string GetTeacher(Courses course);
        public List<Teacher> getallteacher();

        public bool CourseNotFound(Courses course);
        bool CheckIfTeacherIdExists(Teacher teacher);
        List<Courses> getallcourse();




    }
}
