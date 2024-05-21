using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class Students
    {

        int StudentId;
        string FirstName;
        string LastName;
        DateTime Dob;
        string Email;
        string PhoneNumber;
        List<Enrollments> Enrollments;



        public int studentId{get { return StudentId; } set { StudentId = value; }
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

        public DateTime dob
        {
            get { return Dob; } 
            set { Dob = value; } 
        }

        public string email
        {
            get { return Email; } 
            set { Email = value; } 
        }

        public string phoneNumber
        {
            get { return PhoneNumber; } 
            set { PhoneNumber = value; } 
        }
        public List<Enrollments> Enrollment
        {
            get { return Enrollment; }
            set { Enrollment = value; } 
        }


        public override string ToString()
        {
            return $"Student Id : {studentId} || First Name : {firstName} || Last Name : {lastName} || Date of Birth : {dob} || Email : {email} || Phone Number : {phoneNumber} ";
        }

        public Students()
        {

        }

        public Students(int StudentId, string FirstName, string LastName,
        DateTime Dob, string Email, string PhoneNumber)
        {
            studentId = StudentId;
            firstName = FirstName;
            lastName = LastName;
            dob = Dob;
            email = Email;
            phoneNumber = PhoneNumber;
        }
    }
}
