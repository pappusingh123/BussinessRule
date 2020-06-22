/*Created By: Pappu Singh
  Created Date: 22June200
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine;
using BusinessRulesEngine.Constant;
using BusinessRulesEngine.Factory;
using BusinessRulesEngine.Payments;

namespace UnitTestBusinessRulesEngine
{
    [TestClass]
    public class UnitTestPaymentProcess
    {

        [TestMethod]
        public void PaymentFactory_Should_Generate_PackagingSlip_ForPhysicalProduct()
        {
     
            int physicalProduct = PaymentType.ProductDetails.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(physicalProduct);
           
            bool result = paymentObject.ProcessPayment();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Create_DuplicatePackagingSlip_RoyaltyDep_ForBook()
        {
            int book = PaymentType.Employee.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(book);
            bool result = paymentObject.ProcessPayment();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_ActiavteMembership()
        {
            int activate = PaymentType.EmployeeActivate.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(activate);
            bool result = paymentObject.ProcessPayment();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_UpgradeMembership()
        {
            int upgrade = PaymentType.MembershipUpgrade.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(upgrade);
            bool result = paymentObject.ProcessPayment();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_Generate_FreeVideoSlip()
        {
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(video);
            bool result = paymentObject.ProcessPayment();
            Assert.AreEqual(result, true);
        }


    }
}
