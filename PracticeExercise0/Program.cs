namespace PracticeExercise0;

public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine( IsPalindrome("R     A c e c a r " ) );

        Console.WriteLine(ReverseInt( 452) );
        Console.WriteLine(ReverseInt2(452));

    }

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

    public static int ReverseInt2(int i)
    {
        string numberString = i.ToString();

        string reversedNumberString = Reverse(numberString);

        return int.Parse(reversedNumberString);
    }


    public static bool IsUnique(string s)
    {
        return true;
    }

    public static bool IsNeilNumber(int i)
    {
        return true;
    }

    public static string Convert(string s)
    {
        return "";
    }

}

