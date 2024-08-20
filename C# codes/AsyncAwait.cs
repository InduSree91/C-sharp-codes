//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__codes
//{
//    public class AsyncAwait
//    {
//        static async Task Main(string[] args)
//        {
//            Console.WriteLine("Starting.....");

//            await DoWorkAsync();

//            Console.WriteLine("Completed");
//        }

//        static async Task DoWorkAsync()
//        {
//            Console.WriteLine("Wait, Task in Progress");

//            await Task.Delay(1000);

//            Console.WriteLine("Task Completed");
//        }
//    }
//}
