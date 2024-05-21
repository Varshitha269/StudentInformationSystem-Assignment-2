using SIS_Assignment_C_.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Main
{
    public class StudentInformationSystemApp
    {

        readonly StudentRepositoryService _studentrepo;
        readonly EnrollmentsRepositoryService _Enrollmentsrepo;
        readonly PaymentRepositoryService _paymentrepo;
        readonly TeacherRepositoryService _teacherrepo;
        readonly CourseRepositoryService _courserepo;


        public StudentInformationSystemApp()
        {
            _studentrepo = new StudentRepositoryService();

            _Enrollmentsrepo = new EnrollmentsRepositoryService();
            _paymentrepo = new PaymentRepositoryService();
            _teacherrepo = new TeacherRepositoryService();
            _courserepo = new CourseRepositoryService();


        }
        public bool Run()
        {
            bool exit = false;
            while (!exit)
            {
            mainmenu:


                Console.WriteLine("    STUDENT INFORMATION SYSTEM");
                Console.WriteLine("!------------------------------------------!");
                Console.WriteLine();
                Console.WriteLine("Please choose a service:");
                Console.WriteLine();
                Console.WriteLine("  1. Student Services");
                Console.WriteLine("  2. Courses Services");
                Console.WriteLine("  3. Teacher Services");
                Console.WriteLine("  4. Enrollments Services");
                Console.WriteLine("  5. Payment Services");
                Console.WriteLine("  0. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                Console.WriteLine();

                int userInput;
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (userInput)
                {
                    case 1:


                        Console.WriteLine("           STUDENT SERVICE MENU");
                        Console.WriteLine("!------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Add Student");
                        Console.WriteLine("  2. Delete Student");
                        Console.WriteLine("  3. Enroll in Course");
                        Console.WriteLine("  4. Update Student Info");
                        Console.WriteLine("  5. Make Payment");
                        Console.WriteLine("  6. Display Student Info");
                        Console.WriteLine("  7. Get Enrolled Courses");
                        Console.WriteLine("  8. Get Payment History");
                        Console.WriteLine("  0. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int u1;
                        if (!int.TryParse(Console.ReadLine(), out u1))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u1)
                        {
                            case 1:
                                _studentrepo.AddStudent();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _studentrepo.DeleteStudent();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _studentrepo.EnrollInCourse();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 4:
                                _studentrepo.UpdateStudentInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 5:
                                _studentrepo.MakePayment();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                continue;
                            case 6:
                                _studentrepo.DisplayStudentInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();

                                break;
                            case 7:
                                _studentrepo.GetEnrolledCourses();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 8:
                                _studentrepo.GetPaymentHistory();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;
                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }

                        break;

                    case 2:


                        Console.WriteLine("           COURSES SERVICE MENU");
                        Console.WriteLine("!------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Assign Teacher");
                        Console.WriteLine("  2. Update Course Info");
                        Console.WriteLine("  3. Display Course Info");
                        Console.WriteLine("  4. Get Enrollments");
                        Console.WriteLine("  5. Get Teacher Details");
                        Console.WriteLine("  0. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int u2;
                        if (!int.TryParse(Console.ReadLine(), out u2))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u2)
                        {
                            case 1:

                                _courserepo.AssignTeacher();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _courserepo.UpdateCourseInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _courserepo.DisplayCourseInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();

                                break;
                            case 4:
                                _courserepo.GetEnrollments();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 5:
                                _courserepo.GetTeacher();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();

                                break;
                            case 0:
                                goto mainmenu;

                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 3:

                        Console.WriteLine("           TEACHER SERVICE MENU");
                        Console.WriteLine("!------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Update Teacher Info");
                        Console.WriteLine("  2. Display Teacher Info");
                        Console.WriteLine("  3. Get Assigned Courses");
                        Console.WriteLine("  0. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");



                        int u3;
                        if (!int.TryParse(Console.ReadLine(), out u3))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u3)
                        {
                            case 1:
                                _teacherrepo.UpdateTeacherInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _teacherrepo.DisplayTeacherInfo();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _teacherrepo.GetAssignedCourses();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;


                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }


                        break;

                    case 4:


                        Console.WriteLine("        Enrollments SERVICE MENU");
                        Console.WriteLine("!------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Get Student Associated with Enrollments");
                        Console.WriteLine("  2. Get Enrolled Course");
                        Console.WriteLine("  3. Get Enrollments Report");
                        Console.WriteLine("  0. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");




                        int u4;
                        if (!int.TryParse(Console.ReadLine(), out u4))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u4)
                        {
                            case 1:
                                _Enrollmentsrepo.GetStudent();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _Enrollmentsrepo.GetCourse();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _Enrollmentsrepo.GenerateEnrollReport();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;



                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }
                        break;
                    case 5:


                        Console.WriteLine("          PAYMENT SERVICE MENU");
                        Console.WriteLine("!------------------------------------------!");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1. Get Student Associated with Payment");
                        Console.WriteLine("  2. Get Payment Amount");
                        Console.WriteLine("  3. Get Payment Date");
                        Console.WriteLine("  4. Generate Payment Report");
                        Console.WriteLine("  0. Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int u5;
                        if (!int.TryParse(Console.ReadLine(), out u5))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u5)
                        {
                            case 1:
                                _paymentrepo.GetStudent();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _paymentrepo.GetPaymentAmount();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 3:
                                _paymentrepo.GetPaymentDate();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 4:
                                _paymentrepo.GeneratePaymentReport();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;



                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }
                        break;


                    case 0:
                        exit = true;
                        Console.WriteLine("Exited");
                        return false;
                    default:
                        Console.WriteLine("ENTER CORRECT INPUT ");
                        break;
                }







            }
            return true;
        }
    }
    }
