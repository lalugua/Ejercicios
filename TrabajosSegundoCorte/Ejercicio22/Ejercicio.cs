// link de ejercicio:https://edabit.com/challenge/eETZxgueSqivPBmAX
// codigo: 

using System;

public class Program 
{
    public static string FormatDate(string date) 
    {
        string[] dateParts = date.Split('/');
        string formattedDate = dateParts[2] + dateParts[1] + dateParts[0];
        return formattedDate;
    }
}




