/*Created By: Pappu Singh
  Created Date: 22June200
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class EmployeePayment : IPayment
    {
        public bool GenerateDuplicatePackagingSlip()
        {
            Console.WriteLine( "Created Duplicate Packaging slip for employee department successfully");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Payment is done successfully");
            return true;
        }

        public bool ProcessPayment()
        {
            return GenerateDuplicatePackagingSlip();
        }
    }
}
