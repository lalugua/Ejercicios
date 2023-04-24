// link de ejercicio:https://edabit.com/challenge/eETZxgueSqivPBmAX
// codigo: 

using System;

public class Program 
{
    public static bool CheckPalindrome(string word) 
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}




