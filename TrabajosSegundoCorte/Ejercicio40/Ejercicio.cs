// link de ejercicio:https://edabit.com/challenge/4eSei6t8emzpyMwvu
// codigo: 

using System;

public class Program
{
    public static int[] FilterArray(object[] arr)
    {
        List<int> filteredArray = new List<int>();
        
        foreach (object item in arr)
        {
            if (item is int && (int)item >= 0)
            {
                if (!filteredArray.Contains((int)item))
                {
                    filteredArray.Add((int)item);
                }
            }
        }
        
        return filteredArray.ToArray();
    }
}












