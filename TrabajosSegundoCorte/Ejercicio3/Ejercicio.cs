// link de ejercicio: https://edabit.com/challenge/J3WGSreYhc65cWyrc
// codigo: 

using System;

public class Program {
    public static int GetAbsSum(int[] arr) {
        int sum = 0;
        foreach (int num in arr) {
            sum += Math.Abs(num);
        }
        return sum;
    }
}