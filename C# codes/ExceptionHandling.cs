using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class ExceptionHandling
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter first number: ");
           int num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter second number: ");
           int num2 = int.Parse(Console.ReadLine());

           try
           {
               int result = num1 / num2;

               Console.WriteLine("Result is: " + result);
           }
           catch (DivideByZeroException ex)
           {
               Console.WriteLine("You can not divide a number by zero");
               Console.WriteLine(ex.Message); // Prints the message that C# prints
           }

           Console.WriteLine("Ther is no error so this line is printing");
       }
   }
}
