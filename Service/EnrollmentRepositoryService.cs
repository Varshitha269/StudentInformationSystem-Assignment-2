using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Service
{
    public class EnrollmentsRepositoryService
    {
        readonly iEnrollmentsRepository _enrollrepo;
        public EnrollmentsRepositoryService()
        {
            _enrollrepo = new EnrollmentsRepository();
        }

        public void GetStudent()
        {
            try
            {
                Enrollments Enrollments = new Enrollments();
                Console.WriteLine("**** Enrollments Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Enrollments Id");
                Enrollments.enrollId = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enrollments Id {Enrollments.enrollId} :: Student Name :: " + _enrollrepo.GetStudent(Enrollments));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetCourse()
        {
            try
            {
                Enrollments Enrollments = new Enrollments();
                Console.WriteLine("**** Enrollments Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Enrollments Id");
                Enrollments.enrollId = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enrollments Id :: {Enrollments.enrollId} :: Course Name :: " + _enrollrepo.GetCourse(Enrollments));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void GenerateEnrollReport()
        {
            Enrollments Enrollments = new Enrollments();
            Console.WriteLine("**** Enrollments Report Creation****");
            List<Courses> cc = _enrollrepo.getallcourse();
            foreach (Courses cour in cc)
            {
                Console.WriteLine(
 $"Course Id : {cour.CourseId}  " +
 $"Course Name : {cour.CourseName}"
);
            }
            Console.WriteLine("Select Course Id");
            Enrollments.courseId = int.Parse(Console.ReadLine());
            List<Students> stu = _enrollrepo.GenerateEnrollReport(Enrollments);
            foreach (Students a in stu)
            {
                Console.WriteLine(a);
            }


        }




    }
}
