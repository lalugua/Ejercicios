// link de ejercicio:https://edabit.com/challenge/zcuASzWmpFHpPtrbH
// codigo: 

using System;
using System.Linq;

public class Program 
{
    public static string HighLow(string str) 
    {
        var numbers = str.Split(' ').Select(int.Parse);
        return $"{numbers.Max()} {numbers.Min()}";
    }
}











