using System;
using System.Security.Cryptography.X509Certificates;

namespace Helloprogram
{
    internal class Menu_Driven_program
    {
        //Menu-Driven Program
        //create a menu with option
        //area of circle
        //area of rectangle
        //area of triangle
        //use switch-case to perform the selected calculation.
        public static void Run()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    circle();
                    break;
                case 2:
                    rectangle();
                    break;
                case 3:
                    triangle();
                    break;
            }
     
        }
        public static void circle()
        {
            Console.WriteLine("Enter radius of circle:");
            int r = int.Parse(Console.ReadLine());
            double pi = 3.14, result;
            result = pi * r * r;
            Console.WriteLine("Area of circle is:" + result);

        }
        public static void rectangle()
        {
            Console.WriteLine("Enter length");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            double b = double.Parse(Console.ReadLine());
            double result = l * b;
            Console.WriteLine("Area of rectangle is:" + result);
        }
        public static void triangle()
        {
            Console.WriteLine("Enter base");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double h = double.Parse(Console.ReadLine());
            double result = 0.5 * b * h;
            Console.WriteLine("Area of triangle is:" + result);
        }
        
    }
}
