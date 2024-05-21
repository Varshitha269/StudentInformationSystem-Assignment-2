using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.MyExceptions;
using SIS_Assignment_C_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Service
{
    public class CourseRepositoryService

    {
        readonly iCourseRepository _courserepo;
        readonly iTeacherRepository _teachrepo;

        public CourseRepositoryService()
        {
            _courserepo = new CourseRepository();
        }



        public void AssignTeacher()
        {
            try
            {
                Teacher teacher = new Teacher();
                Courses c = new Courses();
                Console.WriteLine("**** Teacher Assignment Department****");
                Console.WriteLine("****Please Fill below details ****");
                List<Courses> cc = _courserepo.getallcourse();
                foreach (Courses cour in cc)
                {
                    Console.WriteLine(
     $"Course Id : {cour.CourseId} || " +
     $"Course Code : {cour.CourseCode} || " +
     $"Course Name : {cour.CourseName}"+$"Instructor Name : {cour.InstructorName}");
                }
                Console.WriteLine("Select Course Id");
                c.CourseId = int.Parse(Console.ReadLine());
                List<Teacher> t2 = _courserepo.getallteacher();
                foreach (Teacher item in t2)
                {
                    Console.WriteLine($"Teacher Id : {item.teacherId} || Teacher Name :: {item.firstName} {item.lastName}");
                }
                Console.WriteLine("Select Teacher Id");
                teacher.teacherId = Convert.ToInt32(Console.ReadLine());

                int status = _courserepo.AssignTeacher(teacher, c);
                if (status > 0) { Console.WriteLine("Assigning Teacher Successful"); }
            }
            catch (TeacherNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayCourseInfo()
        {
            try
            {
                Courses course = new Courses();
                Console.WriteLine("**** Course Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Course Id");
                course.CourseId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(_courserepo.DisplayCourseInfo(course));
            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetEnrollments()
        {
            try
            {
                Courses course = new Courses();
                Console.WriteLine("**** Course Department****");
                Console.WriteLine("****Please Fill below details ****");
                List<Courses> cc = _courserepo.getallcourse();
                foreach (Courses cour in cc)
                {
                    Console.WriteLine(
     $"Course Id : {cour.CourseId} || " +
     $"Course Code : {cour.CourseCode} || " +
     $"Course Name : {cour.CourseName}"+$"Instructor Name : {cour.InstructorName}");
                }
                Console.WriteLine("Course Id");
                course.CourseId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                List<Students> stu = _courserepo.GetEnrollments(course); ;
                foreach (Students item in stu)
                {
                    Console.WriteLine(item);
                }


            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void GetTeacher()
        {
            Courses course = new Courses();
            Console.WriteLine("**** Course Department****");
            Console.WriteLine("****Please Fill below details ****");
            List<Courses> cc = _courserepo.getallcourse();
            foreach (Courses cour in cc)
            {
                Console.WriteLine(
 $"Course Id : {cour.CourseId} || " +
 $"Course Code : {cour.CourseCode} || " +
 $"Course Name : {cour.CourseName}"+$"Instructor Name : {cour.InstructorName}"
);
            }
            Console.WriteLine("Course Id");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Teacher Assigned For Course ID {course.CourseId} :" + _courserepo.GetTeacher(course));

        }

        public void UpdateCourseInfo()
        {
            try
            {
                Console.WriteLine("**** Course Department****");
                Console.WriteLine("****Please Fill below details ****");
                List<Courses> cc = _courserepo.getallcourse();
                foreach (Courses cour in cc)
                {
                    Console.WriteLine(
     $"Course Id : {cour.CourseId} || " +
     $"Course Code : {cour.CourseCode} || " +
     $"Course Name : {cour.CourseName}"
 );
                }
                Console.WriteLine("Course Id");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Course Code");
                string code = (Console.ReadLine());
                Console.WriteLine("Course Name");
                string cname = (Console.ReadLine());
                List<Teacher> t2 = _courserepo.getallteacher();
                foreach (Teacher item in t2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Select The Instructor");
                int instructor = Convert.ToInt32(Console.ReadLine());
                int updatecourse = _courserepo.UpdateCourseInfo(cid, code, cname, instructor);
                if (updatecourse > 0)
                { Console.WriteLine("Course Updation Successful"); }
                else
                    Console.WriteLine("Course Updation UnSuccessful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
