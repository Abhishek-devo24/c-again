using System;

namespace Helloprogram
{
    internal class Decision_making_part2
    {
        //in this code page we solve some new decision making problem like else-if and switch case statement
        //else-if statement is used in condition where we have multiple condition to check
        public static void Run()
        {
            //in this example we check a department of student where student belong and want to take jobs according to their department
            Console.WriteLine("Enter your department name:");
            string department=Console.ReadLine();
            if(department == "bca")
            {
                Console.WriteLine("you are eligible for IT jobs");
            }
            else if (department == "bsc cs")
            {
                Console.WriteLine("you are eligible for IT jobs");
            }
            else if (department == "bsc it")
            {
                Console.WriteLine("you are eligible for IT jobs");
            }
            else if (department == "bcom")
            {
                Console.WriteLine("you are eligible for management jobs");
            }
            else
            {
                Console.WriteLine("your department is not listed here");
            }
                    

        }
    }
}
