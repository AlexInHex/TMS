using System;

namespace Async
{
    internal class CreditCalculator
    {
        private readonly Repository repository = new Repository();

        public CreditInfo Calculate()
        {
            int clientId = repository.GetClientId();
            string firstName = repository.GetFirstName(clientId);
            string lastName = repository.GetLastName(clientId);
            long creditId = repository.GetCreditId(clientId);

            DateTime dateOfCredit = repository.GetDateOfCredit(creditId);
            int creditAmount = repository.GetCreditAmount(creditId);
            int monthlyRate = repository.GetMonthlyRate(creditId);
            int monthlyPayment = repository.GetMonthlyPayment(creditId);
            int creditTerm = repository.GetCreditTerm(creditId);

            // Вычисляем количество месяцев с получения кредита
            int months = 12 * (DateTime.Now.Year - dateOfCredit.Year) + DateTime.Now.Month - dateOfCredit.Month;

            // Вычисляем уже выплаченную сумму
            int paidAmount = months * monthlyPayment;

            // Вычисляем общую сумму платежа по процентам
            double interestCharges = creditAmount * monthlyRate / 100 * creditTerm;

            return new CreditInfo
            {
                FullName = $"{firstName} {lastName}",
                PaidAmount = paidAmount,
                LeftToPay = creditAmount + interestCharges - paidAmount
            };
        }
    }
}
