// link de ejercicio: https://edabit.com/challenge/hjFH2T4Gay7m9ka2m
// codigo: 

using System;

public class Program 
{
    public static string RemoveFirstLast(string str) 
    {
        if (str.Length <= 2)
        {
            return str;
        }
        else
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}