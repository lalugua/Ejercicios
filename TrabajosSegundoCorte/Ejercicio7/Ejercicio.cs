// link de ejercicio: https://edabit.com/challenge/YxoGXwpApf9De7y5w
// codigo: 

using System;

public class Program 
{
    public static int CountDs(string sentence) 
    {
        int count = 0;
        foreach (char c in sentence.ToLower()) 
        {
            if (c == 'd') 
            {
                count++;
            }
        }
        return count;
    }
}