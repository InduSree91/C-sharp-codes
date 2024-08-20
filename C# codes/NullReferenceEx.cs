using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class NullReferenceEx
   {
       static void Main(string[] args)
       {


           try
           {
               string name = "Indu";
               //string name = null; // Name should not be given null as the value

               Console.WriteLine(name.Length);
           }
           catch (NullReferenceException ex)
           {
               Console.WriteLine("Input string is Null");
               Console.WriteLine(ex.Message);
           }

           Console.WriteLine("----------------------");

           Console.WriteLine("This line will run only when the error is handled.");

       }
   }
}
