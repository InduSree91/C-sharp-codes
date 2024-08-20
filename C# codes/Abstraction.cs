//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__codes
//{
//    public abstract class Shape
//    {
//        public abstract double GetArea();
//    }

//    public class Circle : Shape
//    {
//        public double Radius { get; set; }
//        public override double GetArea()
//        {
//            return Math.PI * Radius * Radius;
//        }
//    }

//    public class Square : Shape
//    {
//        public double side { get; set; }
//        public override double GetArea()
//        {
//            return side * side;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Shape myShape = new Circle { Radius = 3.74 };
//            Console.WriteLine(myShape.GetArea());

//            Shape myShape2 = new Square { side = 4 };
//            Console.WriteLine(myShape2.GetArea());
//        }
//    }
//}
