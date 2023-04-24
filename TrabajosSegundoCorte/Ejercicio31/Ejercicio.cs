// link de ejercicio: https://edabit.com/challenge/nvphhA5K6Xhk7FScP
// codigo: 

using System.Text;
public class Program
{
    public static byte[] GetUTF8BOM()
    {
        UTF8Encoding utf8 = new UTF8Encoding(true);
        return utf8.GetPreamble();
    }
}




