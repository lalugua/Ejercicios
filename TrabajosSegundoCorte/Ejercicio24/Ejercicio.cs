// link de ejercicio:https://edabit.com/challenge/eETZxgueSqivPBmAX
// codigo: 

using System;

public class Program 
{
    public static bool XO(string str) 
    {
        str = str.ToLower(); // convert string to lowercase to make it case-insensitive
        int xCount = 0;
        int oCount = 0;
        
        foreach(char c in str) // iterate over each character in the string
        {
            if (c == 'x')
            {
                xCount++;
            }
            else if (c == 'o')
            {
                oCount++;
            }
        }
        
        return xCount == oCount; // return true if the number of x's and o's are equal
    }
}




