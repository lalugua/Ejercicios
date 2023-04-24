// link de ejercicio: https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG

using System;

public class Program
{
    public static int Collatz(int n)
    {
        int steps = 0;
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = n * 3 + 1;
            }
            steps++;
        }
        return steps;
    }
}





