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
            Task<string> firstName = repository.GetFirstName(await clientId);
            Task<string> secondName = repository.GetSecondName(await clientId);
            Task<long> creditId = repository.GetCreditId(await clientId);

            Task<DateTime> dateOfCredit = repository.GetDateOfCredit(await creditId);
            Task<int> creditAmount = repository.GetCreditAmount(await creditId);
            Task<int> monthlyRate = repository.GetMonthlyRate(await creditId);
            Task<int> monthlyPayment = repository.GetMonthlyPayment(await creditId);
            Task<int> creditTerm = repository.GetCreditTerm(await creditId);

            // Вычисляем количество месяцев с получения кредита
            int months =  12 * (DateTime.Now.Year - (await dateOfCredit).Year) + (DateTime.Now.Month - (await dateOfCredit).Month);

            // Вычисляем уже выплаченную сумму
            int paidAmount = months * (await monthlyPayment);

            // Вычисляем общую сумму платежа по процентам
            double interestCharges = (await creditAmount) * (await monthlyRate) / 100 * (await creditTerm);

            return new CreditInfo
            {
                FullName = $"{await firstName} {await secondName}",
                PaidAmount = paidAmount,
                LeftToPay =  await creditAmount + interestCharges - paidAmount
            };
        }
    }
}
