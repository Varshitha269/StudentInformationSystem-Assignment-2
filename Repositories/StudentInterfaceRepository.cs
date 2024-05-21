using SIS_Assignment_C_.Models;
using System;
using System.Data.SqlClient;

namespace SIS_Assignment_C_.Repositories
{
    public interface iStudentRepository
    {

        int AddStudent(Students student);

        int DeleteStudent(Students student);

        int EnrollInCourse(Students student, Courses course);

        int UpdateStudentInfo(Students student);

        int MakePayment(Students student, Payments payment);

        Students DisplayStudentInfo(Students student);

        List<Enrollments> GetEnrolledCourses(Students student);

        List<Payments> GetPaymentHistory(Students student);

        bool CheckIfStudentIdExists(Students student);

        bool CourseNotFound(Courses course);

        bool DuplicateEnrollments(Students student, Courses course);

        List<Students> getallstudent();
        List<Courses> getallcourse();
    }
}
