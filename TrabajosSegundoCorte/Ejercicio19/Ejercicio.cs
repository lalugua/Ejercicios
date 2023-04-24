// link de ejercicio: https://edabit.com/challenge/b59CKJivMhobiqWDu
// codigo: 

using System;

public class Program 
{
    public static string FormatPhoneNumber(int[] numbers) 
    {
        string phoneNumber = string.Join("", numbers); // Convertimos el arreglo de números a una cadena
        return string.Format("({0}) {1}-{2}", phoneNumber.Substring(0, 3), phoneNumber.Substring(3, 3), phoneNumber.Substring(6)); // Formateamos la cadena de números como un número de teléfono y la devolvemos
    }
}

