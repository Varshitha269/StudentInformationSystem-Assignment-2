using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class SIS
    {

        private readonly List<Students> _students;
        private readonly List<Courses> _courses;
        private readonly List<Teacher> _teachers;
        private readonly List<Enrollments> _Enrollments;
        private readonly List<Payments> _payments;





        public SIS()
        {
            _students = new List<Students>();
            _courses = new List<Courses>();
            _Enrollments = new List<Enrollments>();
            _teachers = new List<Teacher>();
            _payments = new List<Payments>();
        }
    }
}
