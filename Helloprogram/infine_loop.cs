using System;

namespace Helloprogram
{
    internal class infine_loop
    {
        public static void Run()
        {
            //in infine loop their is nothing advance here only the things is that don't give condition to stop the loop.
            // it's basically run using boolen value like true and false.
            // here only two thing to stop the loop 1. using break statement 2. using external interuption like ctrl+c
            // and one more thing to continue the loop we can use continue statement.
            //above 2 line is call control statement in loop.
            // Q. print no. from 1 to n using infine loop.
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i==50)
                {
                    break;     // here the break statement is used to stop the loop when i is equal to 50.
                }
            }
        }
    }
}
