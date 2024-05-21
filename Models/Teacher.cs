using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class Teacher
    {
        int TeacherId;
        string FirstName;
        string LastName;
        string Email;
        string Expertise;
        List<Courses> AssignedCourses;


        public List<Courses> assignedCourses
        {
            get { return AssignedCourses; }  
            set { AssignedCourses = value; }  
        }

        public int teacherId
        {
            get { return TeacherId; }  
            set { TeacherId = value; }  
        }

        public string firstName
        {
            get { return FirstName; }  
            set { FirstName = value; }  
        }

        public string lastName
        {
            get { return LastName; }  
            set { LastName = value; }  
        }
        public string email
        {
            get { return Email; }  
            set { Email = value; }  
        }
        public string expertise
        {
            get { return Expertise; }  
            set { Expertise = value; }  
        }

        public override string ToString()
        {
            return $"Teacher Id : {teacherId} || First Name : {firstName} || Last Name : {lastName}  || Email : {email} || Expertise : {expertise} ";
        }
        public Teacher(int TeacherId, string FirstName, string LastName, string Email, string Expertise)
        {
            teacherId = TeacherId;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            expertise = Expertise;
        }
        public Teacher()
        {
        }
    }
}
