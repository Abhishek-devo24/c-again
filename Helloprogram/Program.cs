using System;
namespace Helloprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1= Getdata");
            Console.WriteLine("2= operator");
            Console.WriteLine("3= loops");

            int find = int.Parse(Console.ReadLine());

            switch (find)
            {
                case 1:
                    Getdata.Run();
                    break;
                default:
                    Console.WriteLine("invalid input"); break;
            }
        }

    }
}