using System;
using System.Linq;
var sheeps = new bool[] { true, false, true };
Console.WriteLine(Kata.CountSheeps(sheeps));

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(s => s == true);
    }
}