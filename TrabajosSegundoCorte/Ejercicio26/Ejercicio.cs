// link de ejercicio: https://edabit.com/challenge/2QvnWexKoLfcJkSsc
// codigo: 

using System;

public class Program 
{
    public static int[] ArrayOfMultiples(int num, int length) 
    {
        int[] result = new int[length];
        for (int i = 0; i < length; i++) 
        {
            result[i] = num * (i + 1);
        }
        return result;
    }
}





