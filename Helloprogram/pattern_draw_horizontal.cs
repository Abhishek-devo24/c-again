using System;

namespace Helloprogram
{
    internal class pattern_draw_horizontal
    {
        public static void Run()
        {
            // we are learning about nested loop.
            // print here pattern using nested loop.
            //*****
            //*****
            //*****
            //*****
            // we use here two for loop. 1st is use for row and 2ed is use for column.
            int i, j;
            for (i=1;i<=4;i++)
            {
                for (j=1;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
