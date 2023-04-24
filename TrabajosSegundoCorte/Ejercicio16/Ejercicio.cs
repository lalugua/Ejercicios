// link de ejercicio: https://edabit.com/challenge/FrEEkHfph2pjfE4Ry
// codigo: 

using System;

public class Program 
{
    public static bool DoubleLetters(string word) 
    {
        for (int i = 0; i < word.Length - 1; i++) // Iteramos a través de cada letra en la palabra, excepto la última
        {
            if (word[i] == word[i+1]) // Verificamos si hay dos letras consecutivas idénticas
            {
                return true; // Si encontramos dos letras consecutivas idénticas, devolvemos verdadero
            }
        }
        return false; // Si no encontramos dos letras consecutivas idénticas, devolvemos falso
    }
}