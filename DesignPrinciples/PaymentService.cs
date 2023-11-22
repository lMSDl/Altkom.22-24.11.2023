using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount paymentAccount, float amount)
        {
            return paymentAccount.Charge(amount);
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            paymentAccount.Fund(amount);
        }
    }
} 
