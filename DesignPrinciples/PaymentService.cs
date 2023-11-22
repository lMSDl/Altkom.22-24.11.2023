using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int paymentAccountId, float amount)
        {
            PaymentAccount? paymentAccount = FindById(paymentAccountId);
            if (paymentAccount == null)
                return false;

            if (GetBalance(paymentAccountId) + paymentAccount.AllowedDebit < amount)
                return false;

            paymentAccount.Outcomes += amount;
            return true;
        }

        public void Fund(int paymentAccountId, float amount)
        {
            PaymentAccount? paymentAccount = FindById(paymentAccountId);
            if (paymentAccount == null)
                return;
            paymentAccount.Incomes += amount;
        }

        private PaymentAccount? FindById(int paymentAccountId)
        {
            return PaymentAccounts.Where(x => x.Id == paymentAccountId).SingleOrDefault();
        }

        public float? GetBalance(int paymentAccountId)
        {
            PaymentAccount? paymentAccount = FindById(paymentAccountId);
            return paymentAccount?.Incomes - paymentAccount?.Outcomes;
        }
    }
}
