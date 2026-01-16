using System;

namespace Helloprogram
{
    internal class Pattern_design
    {
        //designing a pattern using nested loop
        //*
        //##
        //***
        //####
        public static void Run()
        {
            int i, j;
            for (i=1;i<=4;i++)
            {
                for (j=1;j<=i;j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }Console.WriteLine();
                
            }
        }
    }
}
