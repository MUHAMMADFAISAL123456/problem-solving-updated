// C# program to remove duplicate character
// from character array and print in sorted
// order
//Time Complexity : O(n* n)
using System;
using System.Collections.Generic;
class GFG
{
    static String GetDuplicateElementsFromArray(char[] str, int n)
    {
        // Used as index in the modified string
        int index = 0;
        char[] strr = new char[250];
        //geeksforgeeks
        // Traverse through all characters
        for (int i = 0; i < n; i++)
        {
            // Check if str[i] is present before it
            int j;
            for (j = 0; j <= i; j++)
            {
                if (str[i] == str[j])
                {
                    break;
                }
            }
            // If not present, then add it to
            // result.
            //geeksforgeeks

            if (j == i)
            {
                //str[index++] = str[i];
            }
            else
            {
                strr[index++] = str[j];
            }
        }
        char[] ans = new char[index];

        Array.Copy(str, ans, index);
        return String.Join("", ans);
    }

    // Driver code
    public static void Main(String[] args)
    {
        char[] str = "google".ToCharArray();
        int n = str.Length;
        Console.WriteLine(GetDuplicateElementsFromArray(str, n));
        Console.ReadLine();
    }
}

// This code is contributed by PrinciRaj1992
