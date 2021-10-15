using System;

namespace Async
{
    internal class Repository
    {
        private readonly FakeDB db = new FakeDB();

        /// <summary>
        /// Возвращает Id клиента
        /// </summary>
        public int GetClientId()
        {
            return db.GetData(1);
        }

        /// <summary>
        /// Возвращает имя
        /// </summary>
        public string GetFirstName(int clientId)
        {
            return db.GetData("Tom");
        }

        /// <summary>
        /// Возвращает фамилию
        /// </summary>
        public string GetLastName(int clientId)
        {
            return db.GetData("Cruise");
        }

        /// <summary>
        /// Возвращает Id кредита
        /// </summary>
        public long GetCreditId(int clientId)
        {
            return db.GetData(12345678987654321);
        }

        /// <summary>
        /// Возвращает дату получения кредита
        /// </summary>
        public DateTime GetDateOfCredit(long creditId)
        {
            return db.GetData(new DateTime(2020, 05, 01));
        }

        /// <summary>
        /// Возвращает сумму кредита
        /// </summary>
        public int GetCreditAmount(long creditId)
        {
            return db.GetData(94000);
        }

        /// <summary>
        /// Возвращает ежемесячный процент по кредиту
        /// </summary>
        public int GetMonthlyRate(long creditId)
        {
            return db.GetData(2);
        }

        /// <summary>
        /// Возвращает ежемесячный платеж по кредиту
        /// </summary>
        public int GetMonthlyPayment(long creditId)
        {
            return db.GetData(4000);
        }

        /// <summary>
        /// Возвращает срок кредита
        /// </summary>
        public int GetCreditTerm(long creditId)
        {
            return db.GetData(24);
        }
    }
}
