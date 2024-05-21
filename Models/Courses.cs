using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class Courses
    {
        int courseId;
        string courseName;
        string courseCode;
        int teacher_id;
        string instructorName;
        List<Enrollments> Enrollments;


        public int CourseId
        {
            get { return courseId; } 
            set { courseId = value; } 
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; } 
        }

        public string CourseCode
        {
            get { return courseCode; } 
            set { courseCode = value; }  
        }
        public int teacherId
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }

        public string InstructorName
        {
            get { return instructorName; }  
            set { instructorName = value; }  
        }

        public List<Enrollments> Enrollment
        {
            get { return Enrollment; }  
            set { Enrollment = value; }  
        }

        public override string ToString()
        {
            return $"Course Id : {CourseId} || Course Name : {CourseName} || Course Name : {CourseCode} ||  Instructor Name : {InstructorName}";
        }

        public Courses()
        {

        }
        public Courses(int CourseId,
        string CourseName,
        string CourseCode,
        string InstructorName)
        {
            courseId = CourseId;
            courseName = CourseName;
            courseCode = CourseCode;
            instructorName = InstructorName;
        }

    }
}
