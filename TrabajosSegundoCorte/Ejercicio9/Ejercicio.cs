// link de ejercicio:https://edabit.com/challenge/xzWM9imvHoSd36iv7
// codigo: 

using System;

public class Program 
{
    public static string GetFilename(string path) 
    {
        int lastSlashIndex = path.LastIndexOf("/");
        return path.Substring(lastSlashIndex + 1);
    }
}