// link de ejercicio:https://edabit.com/challenge/JF25KTZEcPzXhBvpM
// codigo: 

using System;

public class Program 
{   
    public static string GetMiddle(string str) 
    {
        int length = str.Length;
        int middle = length / 2;
        
        if (length % 2 == 0) 
        {
            // even length
            return str.Substring(middle - 1, 2);
        } 
        else 
        {
            // odd length
            return str.Substring(middle, 1);
        }
    }
}











