// link de ejercicio: https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu
// codigo: 

using System;

public class Program
{
    public static string Bomb(string txt)
    {
        string lowerCaseTxt = txt.ToLower(); // Convertimos el string a minúsculas para evitar problemas con la detección de la palabra "bomb" en distintas combinaciones de mayúsculas y minúsculas.
        
        if (lowerCaseTxt.Contains("bomb"))
        {
            return "Duck!!!";
        }
        else
        {
            return "There is no bomb, relax.";
        }
    }
}



