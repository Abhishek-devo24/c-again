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
            Console.WriteLine("5=Decision_making_part2");
            Console.WriteLine("6= Menu_Driven_program");
            Console.WriteLine("7=For_loop");

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
                 case 5:
                    Decision_making_part2.Run();
                    break;
                case 6:
                    Menu_Driven_program.Run();
                    break;
                case 7:
                    For_loop.Run();
                    break;
                default:
                    Console.WriteLine("invalid input"); break;
            }
        }

    }
}