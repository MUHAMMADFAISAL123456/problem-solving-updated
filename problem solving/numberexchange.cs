//// C# Program to add two numbers
//// without using arithmetic operator
//using System;

//class GFG
//{
//    static int Add(int x, int y)
//    {
//        // Iterate till there is no carry
//        while (y != 0)
//        {
//            // carry now contains common
//            // set bits of x and y
//            int carry = x & y;

//            // Sum of bits of x and
//            // y where at least one
//            // of the bits is not set
//            x = x ^ y;

//            // Carry is shifted by
//            // one so that adding it
//            // to x gives the required sum
//            y = carry << 1;
//        }
//        return x;
//    }

//    // Driver code
//    public static void Main()
//    {
//        Console.WriteLine(Add(15, 32));
//        Console.ReadLine();
//    }
//}

//// This code is contributed by vt_m.
