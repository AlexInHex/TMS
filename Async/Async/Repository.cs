using System;
using System.Threading.Tasks;

namespace Async
{
    internal class Repository
    {
        private readonly FakeDB db = new FakeDB();

        /// <summary>
        /// Возвращает Id клиента
        /// </summary>
        public async Task<int> GetClientId()
        {
            return db.GetData(1);
        }

        /// <summary>
        /// Возвращает имя
        /// </summary>
        public async Task<string> GetFullName(int clientId)
        {
            return db.GetData("Tom Cruise");
        }

        /// <summary>
        /// Возвращает Id кредита
        /// </summary>
        public async Task<long> GetCreditId(int clientId)
        {
            return db.GetData(12345678987654321);
        }

        /// <summary>
        /// Возвращает дату получения кредита
        /// </summary>
        public async Task<DateTime> GetDateOfCredit(long creditId)
        {
            return db.GetData(new DateTime(2020, 05, 01));
        }

        /// <summary>
        /// Возвращает сумму кредита
        /// </summary>
        public async Task<int> GetCreditAmount(long creditId)
        {
            return db.GetData(94000);
        }

        /// <summary>
        /// Возвращает ежемесячный процент по кредиту
        /// </summary>
        public async Task<int> GetMonthlyRate(long creditId)
        {
            return db.GetData(2);
        }

        /// <summary>
        /// Возвращает ежемесячный платеж по кредиту
        /// </summary>
        public async Task<int> GetMonthlyPayment(long creditId)
        {
            return db.GetData(4000);
        }

        /// <summary>
        /// Возвращает срок кредита
        /// </summary>
        public async Task<int> GetCreditTerm(long creditId)
        {
            return db.GetData(24);
        }
    }
}
