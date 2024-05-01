using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Module_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a shape that we will find the area of. \n a circle \n a triangle. \n a rectangle. \n or a square.");
            string shape = Console.ReadLine().ToLower();

            if (shape == "circle")
            {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = CircleArea(radius);
            Console.WriteLine($"With a radius of {radius} the area of the circle is {areaOfCircle}\n\n");
            }

            else if(shape == "triangle")
            {

            Thread.Sleep(2000);
            Console.WriteLine("OK now we need the base length and height to find the area of a triangle.");
            Console.WriteLine("Enter the base length:");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("\nGreat now the enter the height:");
            double height = double.Parse(Console.ReadLine());
            double areaOfTriangle = TriangleArea(baseLength, height);
            Console.WriteLine($"\nNow with a base length of {baseLength} and a height {height} the area of the triangle is {areaOfTriangle}.");
            }

            else if (shape == "rectangle")
            {

            Thread.Sleep(2000);
            Console.WriteLine("\n\nOK now we need the base length and width to find the area of a rectangle.");
            Console.WriteLine("Enter the base length:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("\nGreat now the enter the width:");
            double width = double.Parse(Console.ReadLine());
            double areaOfRectangle = RectangleArea(length, width);
            Console.WriteLine($"\nNow with a length of {length} and a width {width} the area of the rectangle is {areaOfRectangle}.");
            }

            else
            {
            Thread.Sleep(2000);

            Console.WriteLine("\n\nNow we need the length of one of the sides of your square.");
            Console.WriteLine("Enter the length of your side:");
            double side = double.Parse(Console.ReadLine());
            double areaOfSquare = SquareArea(side);
            Console.WriteLine($"\nNow with a side length of {side} the area of the square is {areaOfSquare}.");


            }


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
            return area;
        }


    }


}
