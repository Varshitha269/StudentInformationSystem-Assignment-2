using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Models
{
    public class Payments
    {

        int PaymentId;
        int StudentId;
        decimal Amount;
        DateTime PaymentDate;
        Students Student;

        public Students student
        {
            get { return Student; }  
            set { Student = value; }  
        }

        public int paymentId
        {
            get { return PaymentId; }  
            set { PaymentId = value; }  
        }
        public int studentId
        {
            get { return StudentId; }  
            set { StudentId = value; }  
        }
        public decimal amount
        {
            get { return Amount; }  
            set { Amount = value; }  
        }
        public DateTime paymentDate
        {
            get { return PaymentDate; }  
            set { PaymentDate = value; }  


        }

        public override string ToString()
        {
            return $"Payment Id : {paymentId} || Amount: {Amount} || PaymentDate : {paymentDate} ";
        }


        public Payments()
        {

        }

        public Payments(int PaymentId, int StudentId, decimal Amount, DateTime PaymentDate)
        {
            paymentId = PaymentId;
            studentId = StudentId;
            amount = Amount;
            paymentId = PaymentId;
        }
    }
}
