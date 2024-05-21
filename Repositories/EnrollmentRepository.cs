using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.MyExceptions;
using SIS_Assignment_C_.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public class EnrollmentsRepository : iEnrollmentsRepository


    {

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public EnrollmentsRepository()
        {
            sqlConnection = new SqlConnection(sqlConnectionutil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public string GetStudent(Enrollments enroll)
        {

            bool exists = CheckIfEnrollIdExists(enroll);

            if (!exists)
            {
                throw new InvalidEnrollmentsDataException("Invalid Data");
            }
            else
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "select concat (s.first_name + ' ' , s.last_name) as Student_Name from Students s JOIN Enrollments e ON s.student_id = e.student_id WHERE Enrollments_id = @gid";
                cmd.Parameters.AddWithValue("@gid", enroll.enrollId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                string StudentName = Convert.ToString(cmd.ExecuteScalar());
                sqlConnection.Close();
                return StudentName;
            }
        }

        public string GetCourse(Enrollments enroll)
        {
            bool exists = CheckIfEnrollIdExists(enroll);

            if (!exists)
            {
                throw new InvalidEnrollmentsDataException("Invalid Data");
            }
            else
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT course_name from Courses c JOIN Enrollments e ON c.course_id = e.course_id WHERE Enrollments_id = @eid";
                cmd.Parameters.AddWithValue("@eid", enroll.enrollId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                string CName = Convert.ToString(cmd.ExecuteScalar());
                sqlConnection.Close();
                return CName;
            }
        }

        public List<Students> GenerateEnrollReport(Enrollments enroll)
        {
            cmd.Parameters.Clear();
            List<Students> newstu = new List<Students>()
; cmd.CommandText = "SELECT * FROM Students s JOIN Enrollments e ON e.student_id = s.student_id WHERE course_id = @courid";
            cmd.Parameters.AddWithValue("@courid", enroll.courseId); ;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Students stu = new Students();
                stu.studentId = (int)reader["student_id"];
                stu.firstName = (string)reader["first_name"];
                stu.lastName = (string)reader["last_name"];
                stu.dob = (DateTime)reader["date_of_birth"];
                stu.email = (string)reader["email"];
                stu.phoneNumber = (string)reader["phone_number"];
                newstu.Add(stu);

            }
            sqlConnection.Close();
            return newstu;
        }


        public List<Courses> getallcourse()
        {
            cmd.Parameters.Clear();
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

        public bool CheckIfEnrollIdExists(Enrollments enroll)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT COUNT(*) FROM Enrollments WHERE Enrollments_id = @ei ";
                cmd.Parameters.AddWithValue("@ei", enroll.enrollId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();


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
    }
    }
