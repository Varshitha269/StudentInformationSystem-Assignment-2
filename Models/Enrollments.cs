using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class Enrollments
    {

        int EnrollId;
        int StudentId;
        int CourseId;
        DateTime EnrollDate;
        Students Student;
        Courses Course;

        public Students student
        {
            get { return Student; }  
            set { Student = value; }  
        }

        public Courses course
        {
            get { return Course; }  
            set { Course = value; }  
        }


        public int enrollId
        {
            get { return EnrollId; }  
            set { EnrollId = value; }  
        }

        public int studentId
        {
            get { return StudentId; }  
            set { StudentId = value; }  
        }

        public int courseId
        {
            get { return CourseId; }  
            set { CourseId = value; }  
        }

        public DateTime enrollDate
        {
            get { return EnrollDate; }  
            set { EnrollDate = value; }  
        }

        public override string ToString()
        {
            return $"Enrollments Id : {enrollId} || Course Id : {courseId} || Enrollments Date : {enrollDate} ";
        }


        public Enrollments()
        {

        }

        public Enrollments(int EId, int StudentId, int CourseId, DateTime EnrollDate)
        {
            enrollId = EId;
            studentId = StudentId;
            courseId = CourseId;
            enrollDate = EnrollDate;


        }
    }
}
