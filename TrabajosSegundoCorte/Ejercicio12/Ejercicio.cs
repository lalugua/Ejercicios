// link de ejercicio: https://edabit.com/challenge/mcdSLSmXjYMzEmug2
// codigo: 

using System;
public class Program 
{
    public static string FormatDate(string date) 
    {
        string[] dateArr = date.Split('/'); // Separamos la fecha por "/"
        string year = dateArr[2];
        string month = dateArr[0].Length == 1 ? "0" + dateArr[0] : dateArr[0]; // Verificamos si el mes tiene un solo dígito y le agregamos un 0 al inicio si es así
        string day = dateArr[1].Length == 1 ? "0" + dateArr[1] : dateArr[1]; // Verificamos si el día tiene un solo dígito y le agregamos un 0 al inicio si es así
        return year + day + month; // Concatenamos los valores en el orden deseado
    }
}