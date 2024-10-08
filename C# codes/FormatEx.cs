﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__codes
{
   public class FormatEx
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter a Number: ");
           string number = Console.ReadLine();  // When the entered value in number is an alphabetical string that can not be converted into int so we will get Format Exception

           try
           {
               int num = int.Parse(number); // Converts string into int
               Console.WriteLine("Number is: " + num);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("Can not convert higher data type to lower data type");
               Console.WriteLine(ex.Message);
           }
       }
   }
}
