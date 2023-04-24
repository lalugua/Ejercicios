// link de ejercicio: https://edabit.com/challenge/fcGARuJW6tcYyWMQw
// codigo: 

using System;
using System.Linq;

public class Program {
	public static string ToScottishScreaming(string str) {
		return string.Concat(str.Select(c => "AEIOUaeiou".Contains(c) ? 'E' : c).ToString().ToUpper());
	}
}











