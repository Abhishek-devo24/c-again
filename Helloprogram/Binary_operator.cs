using System;

namespace Helloprogram
{
    internal class Binary_operator
    {
        public static void Run()
        {
            // Binary operator types
            // 1.arithmetic operator where perfrom +,-,/,*,%
            //int a = 21, b = 13;
            //int c;
            //c = a + b;
            Console.WriteLine("value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("value of b");
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a + b; //addition
            Console.WriteLine("sum value=" + c);
            c = a - b; //subtraction
            Console.WriteLine("subtraction value=" + c);
            c = a * b; //multiplication
            Console.WriteLine("multiplication=" + c);
            c = a % b; //modulus or remainder
            Console.WriteLine("remainder=" + c);
            c = a / b; //divide
            Console.WriteLine("divide=" + c);
            // Assignment operator (+=, -=,*=,/=,%=)                
            // ex. += a=5, b=6
            //  a+=b  
            //  a=a+b a will be plus with b variable and is equal to value of a 
            Console.WriteLine("enter value of e");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of d");
            int d = int.Parse(Console.ReadLine());
            e += d; //=+ used
            Console.WriteLine("c after used +=:" + e);
            e -= d; //-= used
            Console.WriteLine("c after used -=: " + e);
            e *= d; // *= used
            Console.WriteLine("c after used *=:" + e);
            e %= d;
            Console.WriteLine("c after used %=:" + e);
            // Relational operator (==, !=, >, <, >=, <=) used in condition and compare two values
            Console.WriteLine("enter value of x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of y");
            int y = int.Parse(Console.ReadLine());
            if (x > y) // >
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is not greater than x");
            }
            if (y == x) // ==
            {
                Console.WriteLine("y is equal to x");
            }
            else   // also we used != for this statement
            {
                Console.WriteLine("y is not equal to x");
            }
            if (x <= y) 
            {
                Console.WriteLine("y is greater than equal to x");
            }
            if(y <= x && y< x)
            {
                Console.WriteLine();
            } 
            Console.ReadKey();

        }
    }
}
