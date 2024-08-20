using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class AccessModifier
   {
       class Car
       {
           private string model = "Skoda";  // only be accessed within the same class

           // public access modifier, is accessible for all the classes

           static void Main(string[] args)
           {
               Car car = new Car();

               Console.WriteLine(car.model);
           }
       }
   }
}
