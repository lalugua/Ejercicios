// link de ejercicio: https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD
// codigo: 

public static bool ValidatePIN(string pin)
{
    if (pin.Length == 4 || pin.Length == 6)
    {
        foreach (char c in pin)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
    return false;
}





