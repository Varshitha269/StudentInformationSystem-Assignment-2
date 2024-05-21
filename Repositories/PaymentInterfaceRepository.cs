using SIS_Assignment_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Repositories
{
    public interface iPaymentRepository
    {
        Students GetStudent(int paymentId);
        decimal GetPaymentAmount(int paymentId);
        DateTime GetPaymentDate(int paymentId);
        public List<Payments> GeneratePaymentReport(Students student);
        public List<Students> getallstudent();
        public bool CheckPayIdExists(int pay);



    }
}
