// link de ejercicio: https://edabit.com/challenge/b5HL5ju3Fpx5zjoXn
// codigo: 

using System;
public class Program
{
    public static int gcd(int n1, int n2)
    {
        while (n2 != 0)
        {
            int remainder = n1 % n2;
            n1 = n2;
            n2 = remainder;
        }
        return n1;
    }
}











