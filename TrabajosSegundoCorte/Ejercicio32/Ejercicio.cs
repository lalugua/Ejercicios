// link de ejercicio: https://edabit.com/challenge/zn3A3AAzoE7vezw7Q
// codigo: 

using System.Text;

public class Program
{
    public static int CountOnes(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if ((n & 1) == 1)
            {
                count++;
            }
            n = n >> 1;
        }
        return count;
    }
}




