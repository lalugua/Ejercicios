// link de ejercicio:https://edabit.com/challenge/hqTYj7NbLnCcjxryi
// codigo: 

using System;

public class Program
{
    public static double[] FindLargest(double[][] arr)
    {
        double[] result = new double[arr.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[i].Max();
        }
        
        return result;
    }
}




