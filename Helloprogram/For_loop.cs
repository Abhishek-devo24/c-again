using System;

namespace Helloprogram
{
    internal class For_loop
    {
        // Here, we learn about for loop. loop mean excute the code multiple time as par our requirement. 
        // we know that in loop, have 2 types 1. finite loop and 2. infinite loop
        // finite mean, have fix no. of iteration. here we have two type for and while loop 
        public static void Run()
        {
            // Q. print 1 to 10 using for loop.
            //int i, n;
            //Console.WriteLine("enter no. for print from 1");
            //n = int.Parse(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //Q. print sum of no from one to two. where we get data by the user like 1st and 2ed no.
            //int i, n, k, sum;
            //sum = 0;
            //Console.WriteLine("enter first no.");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second no.");
            //k = int.Parse(Console.ReadLine());
            //for (i = n; i <= k; i++)
            //{
            //    sum = sum + i;

            //}
            //Console.WriteLine($"sum of no. from 1st and 2ed{sum}");
            //Q. print even no. bitween two no. which user give
            int i, n, k;
            Console.WriteLine("enter first no.");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            k = int.Parse(Console.ReadLine());
            for (i=n;i<=k;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
