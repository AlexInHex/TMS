using System;
using System.Diagnostics;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            CreditCalculator calculator = new CreditCalculator();
            Stopwatch sw = Stopwatch.StartNew();
            CreditInfo info = calculator.Calculate();

            Console.WriteLine($"Время загрузки: {sw.Elapsed}");
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
