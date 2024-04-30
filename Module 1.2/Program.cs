using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Module_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            int Added = Add(2, 3);
            Console.WriteLine(Added);

            int subtract = Sub(10, 5);
            Console.WriteLine(subtract);

            int multi = Mult(4, 7);
            Console.WriteLine(multi);

            int Diviv = Div(10, 2);
            Console.WriteLine(Diviv);
        }

        public static double CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;

        }

        public static double TriangleArea(double baseLength, double height)
        {
            double area = height * baseLength / 2;
            return area;
        }

        public static double RectangleArea(double lenght, double width)
        {
            double area = lenght * width;
            return area;
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
        }


    }


}
