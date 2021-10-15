using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Ticker
    {
        private readonly Action action;
        private readonly int milsec;
        private readonly ManualResetEvent threadFinish = new ManualResetEvent(true); 
        public bool IsRun { get; private set; }
        public Ticker(Action action, int sec)
        {
            this.action = action;
            this.milsec = sec * 1000;
        }


        public void Start()
        {
            if (IsRun)
            {
                return;
            }

            Thread thread = new Thread(() => 
            {
                threadFinish.Reset();
                IsRun = true;
                while (IsRun)
                {
                    action();
                    Thread.Sleep(milsec);
                }
                threadFinish.Set();
            });
            thread.IsBackground = true;
            thread.Start();
        }

        public void Stop()
        {
            IsRun = false;
            threadFinish.WaitOne();
        }

        public void Restart()
        {
            Stop();
            Start();
        }


    }
}
