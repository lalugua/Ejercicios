// link de ejercicio: https://edabit.com/challenge/FrEEkHfph2pjfE4Ry
// codigo: 

using System;

public class Program 
{
    public static string DoubleChar(string str) 
    {
        string result = ""; // Creamos una cadena vacía para almacenar el resultado
        foreach (char c in str) // Iteramos a través de cada carácter en la cadena de entrada
        {
            result += c.ToString() + c.ToString(); // Concatenamos cada carácter dos veces a la cadena de resultado
        }
        return result; // Devolvemos la cadena de resultado con cada carácter repetido dos veces
    }
}
