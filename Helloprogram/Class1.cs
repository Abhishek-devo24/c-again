using System;

namespace Helloprogram
{
    public class Getdata
    {
        public static void Run()
        {
            Console.Write("Enter emp id: ");
            int empid = int.Parse(Console.ReadLine());

            Console.Write("Enter emp name: ");
            string empname = Console.ReadLine();

            Console.Write("Enter emp salary: ");
            double empsalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Emp ID={empid}, Name={empname}, Salary={empsalary}");
            Console.ReadKey();
        }
    }
}
