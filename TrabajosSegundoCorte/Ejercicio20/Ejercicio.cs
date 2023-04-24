// link de ejercicio: https://edabit.com/challenge/b59CKJivMhobiqWDu
// codigo: 

using System;

public class Program 
{
    public static bool IsAvgWhole(int[] arr) 
    {
        int sum = 0;
        foreach (int num in arr) 
        {
            sum += num;
        }
        return sum % arr.Length == 0;
    }
}


