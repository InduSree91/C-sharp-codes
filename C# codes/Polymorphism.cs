using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class Polymorphism
   {
       public void Add()
       {
           int a = 12;
           int b = 13;
           int c = a + b;
           Console.WriteLine(c);
       }

       public void Add(int a, int b)
       {
           int c = a + b;
           Console.WriteLine(c);
       }

       public void Add(string a, string b)
       {
           string c = a + b;
           Console.WriteLine(c);
       }

       public void Add(float a, float b)
       {
           float c = a + b;
           Console.WriteLine(c);
       }

       static void Main(string[] args)
       {
           Polymorphism p = new Polymorphism();

           p.Add();
           p.Add(2, 4);
           p.Add("Hello", " World!");
           p.Add(2.34F, 9.36F);
       }
   }
}
