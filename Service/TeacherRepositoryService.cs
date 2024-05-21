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
    public class TeacherRepositoryService
    {
        readonly iTeacherRepository _teacherrepository;

        public TeacherRepositoryService()
        {
            _teacherrepository = new TeacherRepository();
        }

        public void UpdateTeacherInfo()
        {
            try
            {


                Teacher teacher = new Teacher();
                Console.WriteLine("****Teacher Detail Updation Menu****");
                Console.WriteLine("Teacher Id");

                teacher.teacherId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("First Name");
                teacher.firstName = (Console.ReadLine());
                Console.WriteLine("Last Name");
                teacher.lastName = (Console.ReadLine());
                Console.WriteLine(" Email");
                teacher.email = (Console.ReadLine());
                if (!teacher.email.Contains("@"))
                {
                    throw new InvalidTeacherDataException("Invalid email format. Please use the format: abc@example.com");
                }
                Console.WriteLine(" Expertise");
                teacher.expertise = (Console.ReadLine());
                int status = _teacherrepository.UpdateTeacherInfo(teacher);
                if (status > 0)
                {
                    Console.WriteLine("Teacher Information Updated");
                }
            }
            catch (TeacherNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidTeacherDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DisplayTeacherInfo()
        {

            try
            {
                Console.WriteLine("**** Teacher Management****");
                Teacher teach1 = new Teacher();
                Console.WriteLine("Enter Teacher Id");
                teach1.teacherId = Convert.ToInt32(Console.ReadLine());

                // Call service method to retrieve teachers

                Console.WriteLine(_teacherrepository.DisplayTeacherInfo(teach1));
            }
            catch (TeacherNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public void GetAssignedCourses()
        {
            try
            {
                Console.WriteLine("**** Teacher Course Management****");
                Teacher teach1 = new Teacher();
                Console.WriteLine("Enter Teacher Id");
                teach1.teacherId = Convert.ToInt32(Console.ReadLine());

                List<Courses> courses = _teacherrepository.GetAssignedCourses(teach1);

                if (courses.Count > 0)
                {
                    Console.WriteLine("**** List of Courses for Teacher ID: " + teach1.teacherId + " ****");
                    foreach (Courses course in courses)
                    {
                        Console.WriteLine($"{course.CourseId} - {course.CourseName} ({course.CourseCode})"); //teacher id to be added left
                    }
                }
                else
                {
                    Console.WriteLine("No courses found for teacher ID: " + teach1.teacherId);
                }

            }
            catch (TeacherNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }
