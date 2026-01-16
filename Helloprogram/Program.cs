using System;

namespace Helloprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Getdata");
            Console.WriteLine("2 = Operator");
            Console.WriteLine("3 = Binary_operator");
            Console.WriteLine("4 = Decision_making");
            Console.WriteLine("5 = Decision_making_part2");
            Console.WriteLine("6 = Menu_Driven_program");
            Console.WriteLine("7 = For_loop");
            Console.WriteLine("8 = While_loop");
            Console.WriteLine("9 = Do_while");
            Console.WriteLine("10 = Infinite_loop");
            Console.WriteLine("11 = Nested_loop");
            Console.WriteLine("12 = pattern_draw_horizontal");
            Console.WriteLine("13 = Pattern_design");   

            Console.WriteLine("enter a no.");
            string input = Console.ReadLine();

            // ✅ Safe input handling (no FormatException)
            if (!int.TryParse(input, out int find))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
                return;
            }
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

                case 8:
                    While_loop.Run();
                    break;

                case 9:
                    Do_while.Run();
                    break;

                case 10:
                    infine_loop.Run();
                    break;
                case 11:
                    Nested_loop.Run();
                    break;  
                case 12:
                    pattern_draw_horizontal.Run();
                    break;
                case 13:
                    Pattern_design.Run();
                    break;  
                default:
                    Console.WriteLine("Invalid option selected");
                    break;
            }
        }
    }
}
