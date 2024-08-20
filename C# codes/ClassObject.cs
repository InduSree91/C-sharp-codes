using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class Program
   {

       static void Main(string[] args)
       {
           Car myCar = new Car { Brand = "Toyota", Model = "Corolla", Year = 2024 };
           myCar.Start();
       }
   }

   public class Car
   {
       public string Brand { get; set; }
       public string Model { get; set; }
       public int Year { get; set; }

       public void Start()
       {
           Console.WriteLine($"The car of the brand {Brand} and model {Model} manufactured in the year {Year} ");

           Console.WriteLine("Car has Started");
       }
   }
}
