// link de ejercicio: https://edabit.com/challenge/Lmhmtj3QZw9cF5Zew
// codigo: 

using System;

public class Program 
{
    public static string Repeat(string str, int n) 
    {
        string repeatedStr = "";
        foreach (char c in str) 
        {
            for (int i = 0; i < n; i++) 
            {
                repeatedStr += c;
            }
        }
        return repeatedStr;
    }
}



