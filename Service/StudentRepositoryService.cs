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
    public class StudentRepositoryService
    {
        readonly iStudentRepository _studentrepo;


        public StudentRepositoryService()
        {
            _studentrepo = new StudentRepository();
        }

        public void AddStudent()
        {
            try
            {
                Students student = new Students();
                Console.WriteLine(
    "**** Student Added Department****"
);
                Console.WriteLine(
                    "****Please Fill below details of the Student****"
                );
                Console.WriteLine(" First Name");
                student.firstName = Console.ReadLine();
                Console.WriteLine(" Last Name");
                student.lastName = Console.ReadLine();
                Console.WriteLine(" Date of Birth (format: yyyy-MM-dd)");
                student.dob = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine(" Email ");
                student.email = Console.ReadLine();
                if (!student.email.Contains("@"))
                {
                    throw new InvalidStudentDataException("Invalid email format. Please use the format: abc@example.com");

                }


                Console.WriteLine(" Phone Number ");
                student.phoneNumber = (Console.ReadLine());
                if (student.phoneNumber.Length > 10 || student.phoneNumber.Length < 10)
                {
                    throw new InvalidStudentDataException("Phone Number Contains More Than 10 Numbers");
                }


                _studentrepo.AddStudent(student);

            }
            catch (InvalidStudentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void DeleteStudent()
        {
            try
            {
                Students student = new Students();
                Console.WriteLine("**** Student Deletion Department****");
                Console.WriteLine("****Please Fill below details of the Student****");
                List<Students> stu = _studentrepo.getallstudent();
                foreach (Students abc in stu)
                {
                    Console.WriteLine(
    $"Student Id : {abc.studentId} \t " +
    $"Name : {abc.firstName} {abc.lastName}"
);
                }
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                _studentrepo.DeleteStudent(student);
            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }


        public void EnrollInCourse()
        {

            try
            {
                Students student = new Students();
                Courses course = new Courses();
                Console.WriteLine("**** Course Enrollments Department****");
                Console.WriteLine("****Please Fill below details of the Student****");
                List<Students> stu = _studentrepo.getallstudent();
                foreach (Students abc in stu)
                {
                    Console.WriteLine(
    $"Student Id : {abc.studentId} \t " +
    $"Name : {abc.firstName} {abc.lastName}"
);
                }


                Console.WriteLine("Enter Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());

                List<Courses> cc = _studentrepo.getallcourse();
                foreach (Courses cour in cc)
                {
                    Console.WriteLine(
     $"Course Id : {cour.CourseId} || " +
     $"Course Code : {cour.CourseCode} || " +
     $"Course Name : {cour.CourseName}"
 );
                }
                

                Console.WriteLine("Select Course Id");
                course.CourseId = Convert.ToInt32(Console.ReadLine());

                int status = _studentrepo.EnrollInCourse(student, course);
                if (status > 0)
                {
                    Console.WriteLine("Enrollments Succesful");
                }

            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (CourseNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (DuplicateEnrollmentsException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }


        public void MakePayment()
        {

            try
            {
                Students student = new Students();
                Payments pay = new Payments();
                Console.WriteLine("**** Payments Department****");

                Console.WriteLine("****Please Fill below details ****");
                List<Students> stu = _studentrepo.getallstudent();
                foreach (Students abc in stu)
                {
                    Console.WriteLine(
    $"Student Id : {abc.studentId} \t " +
    $"Name : {abc.firstName} {abc.lastName}"
);
                }
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Amount");
                pay.amount = Convert.ToInt32(Console.ReadLine());
                if (pay.amount <= 0)
                {
                    throw new PaymentValidationException("Invalid Payment Amount");
                }
                Console.WriteLine("Payment Date (dd-MM-Yyyy)");
                pay.paymentDate = Convert.ToDateTime(Console.ReadLine());
                int status = _studentrepo.MakePayment(student, pay);
                if (status > 0)
                {
                    Console.WriteLine("Payment Succesful");
                }
            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (PaymentValidationException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }

        public void DisplayStudentInfo()
        {
            Students student = new Students();
            Console.WriteLine("**** Student Information Department****");
            Console.WriteLine("****Please Fill below details of the Student****");
            try
            {
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(_studentrepo.DisplayStudentInfo(student));
            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }

        public void UpdateStudentInfo()
        {
            try
            {
                Students student = new Students();
                Console.WriteLine("**** Student Updatation Department****");
                Console.WriteLine("****Please Fill below details of the Student****");
                List<Students> stu = _studentrepo.getallstudent();
                foreach (Students abc in stu)
                {
                    Console.WriteLine(
    $"Student Id : {abc.studentId} \t " +
    $"Name : {abc.firstName} {abc.lastName}"
);
                }
                Console.WriteLine(" Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" First Name");
                student.firstName = Console.ReadLine();
                Console.WriteLine(" Last Name");
                student.lastName = Console.ReadLine();
                Console.WriteLine(" Date of Birth (format: dd-MM-yyyy)");
                student.dob = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine(" Email ");
                student.email = (Console.ReadLine());
                if (!student.email.Contains("@"))
                {
                    throw new InvalidStudentDataException("Invalid email format. Please use the format: abc@example.com");
                }

                Console.WriteLine(" Phone Number ");
                student.phoneNumber = (Console.ReadLine());
                if (student.phoneNumber.Length > 10 || student.phoneNumber.Length < 10)
                {
                    throw new InvalidStudentDataException("Phone Number Should Contain 10 Digits");
                }


                int status = _studentrepo.UpdateStudentInfo(student);
                if (status > 0)
                { Console.WriteLine("Student Updation Succesful"); }
            }
            catch (InvalidStudentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GetPaymentHistory()
        {
            try
            {
                Students student = new Students();
                Console.WriteLine("**** Payments Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                List<Payments> stu = _studentrepo.GetPaymentHistory(student); ;
                foreach (Payments item in stu)
                {
                    Console.WriteLine(item);
                }
            }
            catch (InvalidStudentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void GetEnrolledCourses()
        {
            try
            {
                Students student = new Students();
                Console.WriteLine("**** Enrollments Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());

                List<Enrollments> stu = _studentrepo.GetEnrolledCourses(student);
                foreach (Enrollments item in stu)
                {
                    Console.WriteLine(item);
                }
            }
            catch (InvalidStudentDataException ex)
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
