using SIS_Assignment_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public interface iEnrollmentsRepository
    {

        string GetStudent(Enrollments enroll);
        string GetCourse(Enrollments enroll);
        List<Students> GenerateEnrollReport(Enrollments enroll);
        List<Courses> getallcourse();
        bool CheckIfEnrollIdExists(Enrollments enroll);
    }


}
