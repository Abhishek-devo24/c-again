using System;
class Mlt()
{
    public static void Main()
    {
        //int[,] arr = { { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 3, 4, 5, 6, 7 } };
        //int i, j;
        //for (i = 0; i < 3; i++)
        //{
        //    for (j = 0; j < 5; j++)
        //    {
        //        Console.Write(arr[i, j] + "   ");
        //    }
        //    Console.WriteLine(" ");
        //}
        //Console.WriteLine(arr[2,3]+"");
        // Declare and initialize an array
        int[] arr = { 13,4,66,356,6434 };
        //Console.WriteLine(i[3]);
        int largest = arr[0];
        int secdlargest = arr[0];
        for (int i = 0; i< arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secdlargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secdlargest && arr[i] != largest)
            {
                secdlargest = arr[i];
            }
        }
        Console.WriteLine($"second largest no. in arr ={secdlargest}");
    }

}
    
