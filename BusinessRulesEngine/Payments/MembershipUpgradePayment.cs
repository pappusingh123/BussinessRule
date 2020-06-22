
/*Created By: Pappu Singh
  Created Date: 22June200
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class MembershipUpgradePayment : IPayment
    {

        public bool UpgardeMembership()
        {
            Console.WriteLine("Membership upgraded successfully");
            return this.EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
             Console.WriteLine( "E-mail sent to Employee Membership Upgraded");
             return true;
        }


        public bool ProcessPayment()
        {
            return UpgardeMembership();
        }
    }
}
