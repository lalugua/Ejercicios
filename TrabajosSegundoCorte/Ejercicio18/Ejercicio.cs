// link de ejercicio: https://edabit.com/challenge/HkKNhhdfEGwxm9Fq6
// codigo: 

using System;

public class Program 
{
    public static int[] NoOdds(int[] arr) 
    {
        List<int> evenList = new List<int>(); // Creamos una lista vacía para almacenar los números pares
        foreach (int num in arr) // Iteramos a través de cada número en el arreglo de entrada
        {
            if (num % 2 == 0) // Verificamos si el número es par
            {
                evenList.Add(num); // Si el número es par, lo agregamos a la lista de números pares
            }
        }
        return evenList.ToArray(); // Convertimos la lista de números pares a un arreglo y lo devolvemos
    }
}

