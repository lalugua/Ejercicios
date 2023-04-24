// link de ejercicio: https://edabit.com/challenge/mcdSLSmXjYMzEmug2
// codigo: 

using System;

public class Program 
{
    public static string FormatDate(string date) 
    {
        string[] dateParts = date.Split('/');
        string year = dateParts[2];
        string month = dateParts[0].PadLeft(2, '0');
        string day = dateParts[1].PadLeft(2, '0');
        return year + day + month;
    }
}