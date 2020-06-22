/*Created By: Pappu Singh
  Created Date: 22June200
*/
using BusinessRulesEngine.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultValue;
            Console.WriteLine("Please choose any Order type:");
            Console.WriteLine("1: Product Details\n"+
                              "2: Employee\n"+
                              "3: Employee Memeber\n"+
                              "4: Upgrade to a Employee Memebership\n"+
                              "5: Video\n");
            Console.WriteLine("*************OutPut*******************");
            var getUserInput = Console.ReadLine();
     
            if(Int32.TryParse(getUserInput, out resultValue))
            {
                ProcessPaymentOrder(resultValue);
            }
            else
            {
                 Console.WriteLine("Please enter a valid option Number!");
            }
            Console.Read();
        }

        private static void ProcessPaymentOrder(int PaymentType)
        {
            IPayment paymentProcessing = Factory.PaymentFactory.GetPaymentObject(PaymentType);
            if (paymentProcessing == null)
            {
                Console.WriteLine("Invalid option!");
            }
            else
            {
                paymentProcessing.ProcessPayment();
            }
           
      
        }
    }
}
