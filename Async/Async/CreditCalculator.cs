using System;
using System.Threading.Tasks;

namespace Async
{
    internal class CreditCalculator
    {
        private readonly Repository repository = new Repository();

        public async Task<CreditInfo> Calculate()
        {
            Task<int> clientId = repository.GetClientId();
            Task<string> fullName = repository.GetFullName(await clientId);            
            Task<long> creditId = repository.GetCreditId(await clientId);

            Task<DateTime> dateOfCredit = repository.GetDateOfCredit(await creditId);
            Task<int> creditAmount = repository.GetCreditAmount(await creditId);
            Task<int> monthlyRate = repository.GetMonthlyRate(await creditId);
            Task<int> monthlyPayment = repository.GetMonthlyPayment(await creditId);
            Task<int> creditTerm = repository.GetCreditTerm(await creditId);

            // Вычисляем количество месяцев с получения кредита
            Task<int> months =  12 * (DateTime.Now.Year - dateOfCredit.Year) + DateTime.Now.Month - dateOfCredit.Month;

            // Вычисляем уже выплаченную сумму
            Task<int> paidAmount = months * monthlyPayment;

            // Вычисляем общую сумму платежа по процентам
            double interestCharges = creditAmount * monthlyRate / 100 * creditTerm;

            return new CreditInfo
            {
                FullName = $"{fullName}",
                PaidAmount = paidAmount,
                LeftToPay = creditAmount + interestCharges - paidAmount
            };
        }
    }
}
