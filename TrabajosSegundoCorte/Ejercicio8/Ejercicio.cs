// link de ejercicio: https://edabit.com/challenge/N28EPgcw96zm4Zv5J
// codigo: 

using System;

public class Program 
{
    public static int DivisibleByB(int a, int b) 
    {
        int next = a + 1;
        while (next % b != 0) 
        {
            next++;
        }
        return next;
    }
}
