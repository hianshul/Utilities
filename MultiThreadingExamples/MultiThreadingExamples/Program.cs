using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Join example
            JoinExample.Call();

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Sleep Complete");
            Console.Read();
        }
    }
}
