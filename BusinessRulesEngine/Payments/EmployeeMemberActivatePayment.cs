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
    public class EmployeeMemberActivatePayment : IPayment
    {
        public bool ActivateMembership()
        {
             Console.WriteLine("Employee Members activated successfully");
             return this.EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
             Console.WriteLine( "E-mail sent to Employee Members Activated");
             return true;
        }


        public bool ProcessPayment()
        {
            return ActivateMembership();
            
        }
    }
}
