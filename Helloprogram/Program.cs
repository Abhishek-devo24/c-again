using System;
namespace Helloprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1= Getdata");
            Console.WriteLine("2= Operator");
            Console.WriteLine("3= Binary_operator");
            Console.WriteLine("4= Desicion_making");

            int find = int.Parse(Console.ReadLine());

            switch (find)
            {
                case 1:
                    Getdata.Run();
                    break;
                 case 2:
                    Operator.Run();
                 break;
                 case 3:
                    Binary_operator.Run();
                    break;
                  case 4:
                    Decision_making.Run();
                  break;
                default:
                    Console.WriteLine("invalid input"); break;
            }
        }

    }
}