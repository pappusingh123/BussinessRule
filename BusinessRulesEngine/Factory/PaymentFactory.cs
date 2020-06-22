
/*Created By: Pappu Singh
  Created Date: 22June200
*/
using BusinessRulesEngine.Payments;

namespace BusinessRulesEngine.Factory
{
    /// <summary>
    /// Payment object Factory
    /// More object can be added later
    /// </summary>
    public  class PaymentFactory
    {
        // Factory Method
        public static IPayment GetPaymentObject(int objType)
        {
            IPayment _IPayment;
  
            if (objType == Constant.PaymentType.ProductDetails.GetHashCode())
            {
                _IPayment = new ProductDetailsPayment();
            }
            else if (objType == Constant.PaymentType.Employee.GetHashCode())
            {
                _IPayment = new EmployeePayment();
            }
            else if (objType == Constant.PaymentType.EmployeeActivate.GetHashCode())
            {
                _IPayment = new EmployeeMemberActivatePayment();
            }
            else if (objType == Constant.PaymentType.MembershipUpgrade.GetHashCode())
            {
                _IPayment = new MembershipUpgradePayment();
            }
            else if (objType == Constant.PaymentType.Video.GetHashCode())
            {
                _IPayment = new VideoPayment();
            }
            else
            {
                _IPayment = null;
            }
            return _IPayment;
        }

    }
}
