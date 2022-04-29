using System;
using CSharpBasics;

public class Test
{
    public static void Main()
    {
        Console.WriteLine($"{Anagram}");
    }

    public static bool Anagram(string s1, string s2)
    {
        Console.ReadLine();
        Console.ReadLine();

        char[] letterS1 = s1.ToCharArray();                                     //  convert 1st string to char array
        char[] letterS2 = s2.ToCharArray();                                     //  convert 2nd string to char array

        if (s1.Length == s2.Length)                                             //  if the words are the exact same length
        {
            for (int i = 0; i < letterS2.Length; i++)
            // for (int i = letterS2.Length - 1; i >= 0; i--)                      //  comparing each letter in s1 array to each letter in s2 array 
            {
                int firstLetter = 0;                                              //  initializing from the end of s2
                while (true)
                {
                    firstLetter = s2.IndexOfAny(letterS1);                          //  navigate one character at a time from s1 into s2
                    var lastLetter = s1.Contains(letterS2[letterS1.Length]);
                    if (firstLetter == -1) break;
                    // lastLetter += 1;                                               //  once it comes back to the beginning, it breaks the loop
                }
            }
        }                                                                            //  increments to the next letter
        

        else
        {
            return false;                                       //  if the words are not the same length
        }
        return true;
    }
}
