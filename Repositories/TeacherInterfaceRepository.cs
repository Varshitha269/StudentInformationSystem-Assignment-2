using SIS_Assignment_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public interface iTeacherRepository
    {
        public int UpdateTeacherInfo(Teacher teacher);
        public Teacher DisplayTeacherInfo(Teacher teacher);
        public List<Courses> GetAssignedCourses(Teacher teacher);
        public bool CheckIfTeacherIdExists(Teacher teacher);


    }
}
