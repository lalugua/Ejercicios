// link de ejercicio: https://edabit.com/challenge/FrEEkHfph2pjfE4Ry
// codigo: 

using System;

public class Program
{
    public static string FizzBuzz(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (num % 3 == 0)
        {
            return "Fizz";
        }
        else if (num % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return num.ToString();
        }
    }
}