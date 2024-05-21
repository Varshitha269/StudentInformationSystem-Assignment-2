using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.MyExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public class CourseRepository : iCourseRepository
    {

        Courses course;
        Students student;

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public CourseRepository()
        {
            sqlConnection = new SqlConnection("Server =VARSHITHA; Database = Student Information System; User Id = Varshitha; Password = Varshitha@123; TrustServerCertificate = True");
            cmd = new SqlCommand();

        }

        public int AssignTeacher(Teacher teacher, Courses course)
        {
            bool exists = CheckIfTeacherIdExists(teacher);

            if (!exists)
            {
                throw new TeacherNotFoundException("Invalid Teacher ID");
            }
            else
            {


                bool exists2 = CourseNotFound(course);
                if (!exists2)
                {
                    throw new CourseNotFoundException("Course Not Found");
                }
                else
                {

                    cmd.CommandText = "UPDATE Courses SET teacher_id = @tid WHERE course_id = @cid ";
                    cmd.Parameters.AddWithValue("@tid", teacher.teacherId);
                    cmd.Parameters.AddWithValue("@cid", course.CourseId);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    int returnLeaseStatus = cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    return returnLeaseStatus;
                }
            }
        }

        //private bool CourseNotFound(Courses course)
        //{
        //    throw new NotImplementedException();
        //}

        public Courses DisplayCourseInfo(Courses course)
        {
            bool exists2 = CourseNotFound(course);
            if (!exists2)
            {
                throw new CourseNotFoundException("Course Not Found");
            }
            else
            {

                cmd.CommandText = "SELECT course_id,course_name,course_code,concat(t.first_name + ' ' , t.last_name) as Instructor_Name FROM Courses c JOIN Teacher t ON c.teacher_id = t.teacher_id WHERE course_id = @cid ";
                cmd.Parameters.AddWithValue("@cid", course.CourseId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    course.CourseId = (int)reader["course_id"];
                    course.CourseCode = (string)reader["course_code"];
                    course.CourseName = (string)reader["course_name"];
                    course.InstructorName = (string)reader["Instructor_Name"];
                }
                sqlConnection.Close();
                return course;
            }
        }

        public List<Students> GetEnrollments(Courses course)
        {
            bool exists2 = CourseNotFound(course);
            if (!exists2)
            {
                throw new CourseNotFoundException("Course Not Found");
            }
            else
            {

                List<Students> students = new List<Students>();
                cmd.CommandText = "SELECT * FROM Students s JOIN Enrollments e ON e.student_id = s.student_id WHERE course_id = @cid";
                cmd.Parameters.AddWithValue("@cid", course.CourseId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Students student = new Students();
                    student.studentId = (int)reader["student_id"];
                    student.firstName = (string)reader["first_name"];
                    student.lastName = (string)reader["last_name"];
                    student.dob = (DateTime)reader["date_of_birth"];
                    student.email = (string)reader["email"];
                    student.phoneNumber = (string)reader["phone_number"];
                    students.Add(student);
                }
                sqlConnection.Close();
                return students;

            }
        }

        public string GetTeacher(Courses course)
        {
            bool exists2 = CourseNotFound(course);
            if (!exists2)
            {
                throw new CourseNotFoundException("Course Not Found");
            }
            else
            {


                cmd.CommandText = "select concat(t.first_name + ' ' , t.last_name) as Teacher_Name from Teacher t JOIN Courses c ON c.teacher_id = t.teacher_id WHERE course_id = @cid";
                cmd.Parameters.AddWithValue("@cid", course.CourseId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                string TeacherName = Convert.ToString(cmd.ExecuteScalar()); ;
                sqlConnection.Close();
                return TeacherName;

            }
        }

        public int UpdateCourseInfo(int CourseId, string CourseCode, string CourseName, int instructor)
        {


            cmd.CommandText = "UPDATE Courses SET course_code = @courseCode,course_Name = @courseName,teacher_id = @tid WHERE course_id = @cid ";
            cmd.Parameters.AddWithValue("@cid", CourseId);
            cmd.Parameters.AddWithValue("@courseCode", CourseCode);
            cmd.Parameters.AddWithValue("@courseName", CourseName);
            cmd.Parameters.AddWithValue("@tid", instructor);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int updateinfo = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return updateinfo;

        }

        public List<Teacher> getallteacher()
        {
            cmd.Parameters.Clear();
            List<Teacher> teach = new List<Teacher>();
            cmd.CommandText = "SELECT * FROM Teacher";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher t1 = new Teacher();
                t1.teacherId = (int)reader["teacher_id"];
                t1.firstName = (string)reader["first_name"];
                t1.lastName = (string)reader["last_name"];
                // t1.expertise = reader["expertise"];
                teach.Add(t1);
            }
            sqlConnection.Close();
            return teach;
        }


        public bool CourseNotFound(Courses course)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT COUNT(*) FROM Courses WHERE course_id = @sid";
            cmd.Parameters.AddWithValue("@sid", course.CourseId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            try
            {

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return count > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

                return false;

            }


        }

        public bool CheckIfTeacherIdExists(Teacher teacher)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT COUNT(*) FROM Teacher WHERE teacher_id = @TeacherId";
            cmd.Parameters.AddWithValue("@TeacherId", teacher.teacherId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            try
            {

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                sqlConnection.Close();
                return count > 0;

            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);

                return false;
            }
        }

        public List<Courses> getallcourse()
        {
            List<Courses> cu = new List<Courses>();
            cmd.CommandText = "SELECT * FROM Courses";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Courses c1 = new Courses();
                c1.CourseId = (int)reader["course_id"];
                c1.CourseCode = (string)reader["course_code"];
                c1.CourseName = (string)reader["course_name"];

                cu.Add(c1);
            }
            sqlConnection.Close();
            return cu;
        }

    }
}
