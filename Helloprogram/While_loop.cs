using System;
using System.Diagnostics.CodeAnalysis;

namespace Helloprogram
{
    internal class While_loop
    {
        //while loop is also used to excute the code multiple time as par our requirement.
        //it call entry control loop because condition is checked first then excute the code.
        //Q. add digit in a no. 
        public static void Run()
        {
            //int i, n;
            //int sum = 0;
            //i = 123;
            //while (i!=0)
            //{
            //    n = i % 10;
            //    sum = sum + n;
            //    i=i/ 10;   
            //}
            //Console.WriteLine($"sum of digit={sum}");
            //Q. add digit of no. accrodding to user input
            //Console.WriteLine("enter no. for add digit");
            //int i = int.Parse(Console.ReadLine());
            //int n;
            //int sum = 0;   
            //while (i != 0)
            //{
            //    n = i % 10;
            //    sum = sum + n;
            //    i = i / 10;
            //}
            //Console.WriteLine($"sum of digit={sum}");
            //Q. using while loop print no. like 100,200,300,400....10000
            int i = 1;
            int n;
            while (i<=10)
            {
                n = i * 100;
                i++;
                Console.WriteLine(n);
            }
        }


    }
}
