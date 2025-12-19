using System;

    class Program
    {
        static void Main(string[] args)
        {
        //int empid = 21;
        //string empname = "lala ji";
        //float empsalary = 25000.12f;   // for float, we use the f to determine the decimal value written in float
        //Console.WriteLine("emp id=" + empid);
        //Console.WriteLine("emp name=" + empname);
        //Console.WriteLine("emp salary=" + empsalary);
        //Console.WriteLine("hello bro");
        int empid;
        string empname;
        double empsalary;
        Console.WriteLine("enter emp id,");
        empid = int.Parse(Console.ReadLine()); //for insert value from user we need to be use console.readline
        Console.WriteLine("enter emp name");
        empname = Console.ReadLine(); //syntax for string value from userdeclaration of variable = console.readline();
        Console.WriteLine("enter emp salary");
        empsalary = double.Parse(Console.ReadLine());  //for float / int value from user we need to use double.parse(console.readline()); or int.parse(console.readline());
        Console.WriteLine($"emp id={empid},empname={empname},empsalary{empsalary}" );
        Console.ReadKey(); // to hold the output screen
        }
    }
