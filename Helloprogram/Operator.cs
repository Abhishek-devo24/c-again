using System;

namespace Helloprogram
{
    internal class Operator
    {
        //in c#, thier are two types of operators, 1st unary operator and 2ed binary operator
        //means we perform operation on one operand or two operand(operand kind of variables ex= a,b,c)
        //in unary operator we have one operand like ++a or --a, here we have to perform only 2 operation
        //in binary operator we have two operand like a+b, here we have to perform many operation like +,-,*,/,%,etc
        public static void Run()
        {
            // run our unary operation where perform ++ and -- operation
            int a = 22,b=25;
            ++a; // here we perform pre increment operation, means every time add value by 1 before using it
            --b; // here we perform pre decrement operation, means every time subtract value by 1 before using it
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            // #note we con't perfrom post operation because it go infinite loop.it always used in loop statement
            Console.ReadKey();
        }
    }
}
