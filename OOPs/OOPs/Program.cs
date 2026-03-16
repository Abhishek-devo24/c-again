using System;
using System.Security.Cryptography.X509Certificates;
class OOPs {
    // i create a class name oops and another method name dis1 nd dis2 or main method.
    //here i using object to call method which is different form like ststic nd dynamic.
    //accessmodifier have 4 type public,private,internal,protected.
    public static void dic1()
    {
        Console.WriteLine("static method");
    }
    public void dic2()
    {
        Console.WriteLine("dynamic method");
    }
    public static void Main(string[] args)
    {
       //OOPs run =new OOPs();
       // run.dic2();
        dic1();
    }
}
