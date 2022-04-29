using System;
using CSharpBasics;

public class Test2
{
    public static void Main()
    {
        Console.WriteLine($"{Palindrome}");
    }

    public static bool Palindrome(string s)
    {
        char[] letters = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            int forwardWord = letters.LastIndexOf(letters[i], s);
            int backwardWord = letters.IndexOf(letters[i], s);

            if (forwardWord == backwardWord)                                                   //  first letter must equal last letter
            {
                forwardWord++;
                backwardWord--;                                                                //  for loop, if 1st = last, if 2nd = 2nd to last
            }
            else
            {
                return false;                                                                    //  else, it's false
            }   
        }
        return true;
    }
}