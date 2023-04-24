// link de ejercicio: https://edabit.com/challenge/nermqxzovZbfFBC9X
// codigo: 

using System;

public class Program
{
    public static string[] ParseArray(object[] arr)
    {
        string[] strArr = new string[arr.Length]; // Creamos un nuevo array para guardar los valores convertidos a string.
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] is int) // Si el elemento es un entero, lo convertimos a string.
            {
                strArr[i] = arr[i].ToString();
            }
            else // Si no, simplemente copiamos el valor al nuevo array.
            {
                strArr[i] = arr[i].ToString();
            }
        }
        
        return strArr;
    }
}



