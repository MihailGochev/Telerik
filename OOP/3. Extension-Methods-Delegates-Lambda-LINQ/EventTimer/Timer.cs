//Using delegates write a class Timer that has can execute certain method at each t seconds.
namespace TimerClass
{
    using System;
    using System.Threading;

    public class Timer
    {
        private delegate void DoSomething();
        private bool hasMethods = false;
        private DoSomething doSomething;

        public void AddMethod(Action act)
        {
            hasMethods = true;
            doSomething += new DoSomething(act);
        }

        public void Run(double runTime, double timeInterval)
        {
            if (runTime < 0 || timeInterval < 0)
            {
                throw new ArgumentException("Negative time!");
            }

            if (hasMethods)
            {
                for (double time = 0; time < runTime; time += timeInterval)
                {
                    Thread.Sleep((int)(timeInterval * 1000));
                    doSomething();
                }
            }
            else
            {
                Console.WriteLine("No methods added to delegate!");
            }
        }
    }
}