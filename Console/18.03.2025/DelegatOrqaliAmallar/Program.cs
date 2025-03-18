using System;
using static System.Console;

namespace Delegat;

delegate double Amal(double a, double b);

public static class Program
{
    static double Qoshish(double a, double b)
    {
        Console.WriteLine($"Qo'shish amali: {a} + {b} = {a + b}");
        return a + b;
    }

    static double Ayirish(double a, double b)
    {
        Console.WriteLine($"Ayirish amali: {a} - {b} = {a - b}");
        return a - b;
    }

    static double Kopaytirish(double a, double b)
    {
        Console.WriteLine($"Ko'paytirish amali: {a} * {b} = {a * b}");
        return a * b;
    }

    static double Bolish(double a, double b)
    {
        Console.WriteLine($"Bo'lish amali: {a} / {b} = {a / b}");
        return a / b;
    }


    public static void Main()
    {
        Write("x sonni kiriting: ");
        double x = double.Parse(ReadLine());
        Write("y sonni kiriting: ");
        double y = double.Parse(ReadLine());

        Amal amal = new Amal(Qoshish);
        amal(x, y);

        amal = new Amal(Ayirish);
        amal(x, y);

        amal = new Amal(Kopaytirish);
        amal(x, y);

        amal = new Amal(Bolish);
        amal(x, y);
    }
}