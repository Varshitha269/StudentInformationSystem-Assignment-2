using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.MyExceptions;
using SIS_Assignment_C_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Service
{
    public class PaymentRepositoryService
    {
        readonly iPaymentRepository _paymentrepository;

        public PaymentRepositoryService()
        {
            _paymentrepository = new PaymentRepository();
        }

        public void GetStudent()
        {
            try
            {
                Console.WriteLine("**** Payment Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Payment Id");
                int paymentId = int.Parse(Console.ReadLine());
                Students infostudent = _paymentrepository.GetStudent(paymentId);
                Console.WriteLine("Student Id " + infostudent.studentId + " " + "Student Name ::" + infostudent.firstName + " " + infostudent.lastName + "Of Paymed ID" + paymentId);
            }
            catch (PaymentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void GetPaymentAmount()
        {
            try
            {
                Console.WriteLine("**** Payment Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Payment Id");
                int paymentId = int.Parse(Console.ReadLine());


                decimal paymentAmount = _paymentrepository.GetPaymentAmount(paymentId);
                if (paymentAmount > 0)
                {
                    Console.WriteLine("Payment amount for ID " + paymentId + ": " + paymentAmount);
                }
            }
            catch (PaymentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetPaymentDate()
        {
            try
            {
                Console.WriteLine("**** Payment Department****");
                Console.WriteLine("****Please Fill below details ****");
                Console.WriteLine("Payment Id");
                int paymentId = int.Parse(Console.ReadLine());

                decimal paymentAmount = _paymentrepository.GetPaymentAmount(paymentId);
                DateTime paymentDate = _paymentrepository.GetPaymentDate(paymentId);
                if (paymentDate != null)
                {
                    Console.WriteLine("Payment date for ID " + paymentId + ": " + "Payment Amount " + ": " + paymentAmount + "Payment Amount " + ": " + paymentDate.ToString("yyyy-MM-dd"));
                }
            }
            catch (PaymentDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GeneratePaymentReport()
        {
            Students stuu = new Students();
            Console.WriteLine("**** Payment Report Creation****");
            List<Students> stu = _paymentrepository.getallstudent();
            foreach (Students s1 in stu)
            {
                Console.WriteLine(
$"Student Id : {s1.studentId} \t " +
$"Name : {s1.firstName} {s1.lastName}"
);
            }


            Console.WriteLine("Select Student Id");
            stuu.studentId = int.Parse(Console.ReadLine());
            List<Payments> abc = _paymentrepository.GeneratePaymentReport(stuu);
            foreach (Payments a in abc)
            {
                Console.WriteLine(a);
            }

        }



    }
}
