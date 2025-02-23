using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Synchronous, Asynchronous, Parallel

            // one by one, one started and pause ( I/O, Network Request, Database Calls )

            // AM async Task MethodName(parameter)

            //await ShowOutPut();
            //await ShowOutPut();
            //await ShowOutPut();

            //Task t1 = ShowOutPut();
            //Task t2 = ShowOutPut();
            //Task t3 = ShowOutPut();
            //await Task.WhenAll(t1, t2, t3);

            // Linux Troval -> Community 
            // Ubuntu, Kali, CenseOS, Math, Open Suse, 
            // Git Extensions, Fork, SVN

            // Thread

            //Thread t=new Thread (()=>SayYes("abc"));
            //t.Start ();

            //for (int i = 0;i<100;i++)
            //{
            //    Console.Write("x");
            //}


            //Console.WriteLine();

            // Task
            //await Task.Run(() => Console.WriteLine("Hello"));

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Task Started");
                Thread.Sleep(2000);
                Console.WriteLine("Hello");
            });
            Console.WriteLine(t1.IsCompleted); // false
            t1.Wait();
        }

        static void SayYes(string s)
        {
            for(int i=0;i<100;i++)
            {
                Console.Write("y");
            }
        }

        public static async Task ShowOutPut()
        {
            Console.WriteLine("Hello Async");

            await Task.Delay(2000);

            Console.WriteLine("Finished");
        }
    }
}
