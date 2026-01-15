using System;


namespace Helloprogram
{
    internal class Nested_loop
    {
        public static void Run()
        {
            // we are learning about nested loop.
            // print here pattern using nested loop.
            //*
            //**
            //***
            //****
            // we use here two for loop. 1st is use for row and 2ed is use for column.
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i=4;i>=1;i--)
            {
                for (j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
