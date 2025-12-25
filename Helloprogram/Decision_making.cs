using System;

namespace Helloprogram
{
    internal class Decision_making
    {
        public static void Run()
        {
            // Decision making statements are used to decide the flow of control in a program based on certain conditions.
            // Common decision-making statements in C# include if, if-else, nested if-else.
            // Example of if, if-else and nested if-else statements.
            //example of if statement Amt withdraw from Atm. where amount withdraw using pin no. and check balance amt. if amt satify the condition where withdraw
            //amt less than equal to blance amt.if withdraw amt not satify the condition then show insufficient balance
            double availableBalance = 50000, balance_amt;
            int pin_no = 000;
            Console.WriteLine("Enter your pin no:");
            int upin=int.Parse(Console.ReadLine());
            if (upin == pin_no)
            {
                Console.WriteLine("pin_no is correct");
                Console.WriteLine("enter amt for withdraw");
                int withdrawAmt = int.Parse(Console.ReadLine());
                if (withdrawAmt <= availableBalance)
                {
                    Console.WriteLine("transaction is successfull");
                    balance_amt = availableBalance - withdrawAmt;
                    Console.WriteLine($"withdraw amt is {withdrawAmt} and balace amt in account is {balance_amt}");
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("pin_no is incorrect,re-try again");
            }

        }
    }
}
