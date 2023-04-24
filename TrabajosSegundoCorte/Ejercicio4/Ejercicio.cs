// link de ejercicio: https://edabit.com/challenge/YciBg83ihMfGGsA7F
// codigo: 

using System;

public class Program {
    public static string NSidedShape(int n) {
        string[] shapes = {"circle", "semi-circle", "triangle", "square", "pentagon", "hexagon", "heptagon", "octagon", "nonagon", "decagon"};
        return shapes[n - 1];
    }
}