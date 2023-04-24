// link de ejercicio: https://edabit.com/challenge/5ytLyHsZHfyDhBgXr
// codigo: 

using System;

public class Program 
{
    public static int CountVowels(string str) 
    {
        int count = 0;
        foreach (char c in str.ToLower()) 
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') 
            {
                count++;
            }
        }
        return count;
    }
}