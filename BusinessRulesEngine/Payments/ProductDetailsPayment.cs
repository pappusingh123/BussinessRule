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
    public class ProductDetailsPayment : IPayment
    {
        public bool GeneratePackagingSlip()
        {
            Console.WriteLine("Generated Packaging slip for shipping employee successfully");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Payment done successfully");
            return true;
        }

        public bool ProcessPayment()
        {
            return GeneratePackagingSlip();
        }
    }
}
