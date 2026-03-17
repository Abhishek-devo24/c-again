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
    public void ascending() // dynamic method which is call by object in main method for run
    {
        int[] arr = new int[5];
        for (int i=0;i<arr.Length;i++) {
            arr[i] = int.Parse(Console.ReadLine());
        
        }
        Array.Sort(arr);
        Console.WriteLine("ascending order");
        foreach (int r in arr)
        {
            Console.WriteLine(r);
        }
    }
    public static void decending() // static method which is call by without object in main method
    {
        int[] array = new int[7];
        for (int i=0;i<array.Length;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine("decending order");
        foreach (int k in array)
        {
            Console.WriteLine(k);
        }

    }
    public static void Main(string[] args)
    {
       OOPs run =new OOPs();
        //run.dic2();
        // dic1();
        decending();
        Console.WriteLine("now turn of ascending order");
        run.ascending();
    }
}
