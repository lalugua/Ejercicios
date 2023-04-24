// link de ejercicio: https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw
// codigo: 

public class Program
{
    public static int[] CountPosSumNeg(int[] arr)
    {
        int countPos = 0;
        int sumNeg = 0;

        foreach (int num in arr)
        {
            if (num > 0)
            {
                countPos++;
            }
            else if (num < 0)
            {
                sumNeg += num;
            }
        }

        return new int[] { countPos, sumNeg };
    }
}




