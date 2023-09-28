﻿namespace PracticeExercise0;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine( IsPalindrome("R     A c e c a r " ) );

        Console.WriteLine(ReverseInt( 452) );
        Console.WriteLine(ReverseInt2(452));

    }

    /***
     * Write a method that will take a string and determine if the 
     * string is a palindrome (the same forwards and backward). 
     * Ignore the case and all spaces. 
    */
    public static bool IsPalindrome(string s)
    {
        // clean up
        string cleanString = s.Replace(" ", "").ToLower();

        // reverse and see if it's equal to

        return cleanString == Reverse(cleanString); 
    }

    private static string Reverse(string original)
    {
        string reversed = "";

        foreach(char c in original)
        {
            reversed = reversed.Insert(0,c.ToString() );  
        }

        return reversed;
    }


    /***
     * Write a method that accepts an integer (positive or negative) and 
     * returns the “reversed” number, but retains the sign. 
     */
    public static int ReverseInt(int i)
    {
        //325%10 => 5
        //325/10 => 32

        //32%10 => 2
        //32/10 => 3

        //3%10 => 3
        //3/10 => 0

        int x = i;
        int reverse = 0;

        while( x != 0)
        {
            int remainder = x % 10;
            reverse = reverse * 10 + remainder;

            x = x / 10;
        }

        return reverse;
    }

    // This doesn't handle negative numbers correctly.
    public static int ReverseInt2(int i)
    {
        string numberString = i.ToString();

        string reversedNumberString = Reverse(numberString);

        return int.Parse(reversedNumberString);
    }


    /***
     * Write a function that will accept a string of alphabetic characters 
     * and determine if all the characters are unique (i.e., no characters 
     * are duplicated). 
     * This comparison should be case INsensitive and ignore spaces.
     */
    public static bool IsUnique(string s)
    {
        return true;
    }


    /***
     * A Neil number of m digits is an integer such that the sum of its 
     * digits raised to the mth power is equal to the number itself. For 
     * example, 371 is a Neil number since 33 + 73 + 13 = 371. Write the 
     * following method to test an integer for this property.
     */
    public static bool IsNeilNumber(int i)
    {
        int numDigits = (int)Math.Floor(Math.Log10(i)) + 1;
        foreach (char digit in i.ToString())
        {
            Console.WriteLine(digit);
            //convert char to int
            int number = int.Parse(digit.ToString());

            int power = (int)Math.Pow(5, 8);
        }

        return true;
    }


    /***
     * 
     * Write a function that converts phone numbers from this format: 
     * "7three1-6zero8-3one35" 
     * to the standard format:
     * "731-608-3135"
     */
    public static string Convert(string s)
    {
        string result = s.ToLower().Trim().Replace("zero", "0");
        result = result.Replace("one", "1");
        return result;
    }

}

