using System;

namespace Helloprogram
{
    internal class Do_while
    {
        public static void Run()
        {
            //do while loop is exit control loop because in this loop code is excute first then condition is checked.
            //Q. print no. from 1 to 10 using do while loop.
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i<=5);
        }
    }
}
