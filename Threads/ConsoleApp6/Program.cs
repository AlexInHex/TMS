using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ticker ticker = new Ticker(() => Console.WriteLine("///"), 1);
            //ticker.Start();
            //Thread.Sleep(5000);
            //ticker.Stop();

            int[] array = Enumerable.Range(1, 1000_000).ToArray();
            long count = 0;

            foreach (var item in array)
            {
                count += item;
            }
            Console.WriteLine(count);
            Counter counter = new Counter(array);
            Console.WriteLine(counter.Calculate());

            Console.ReadKey();
        }
    }
}
