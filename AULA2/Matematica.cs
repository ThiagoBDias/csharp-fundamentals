using System;
using System.Globalization;

public class Matematica
{
    double  x = 3.0;
    double  y = 4.0;
    double z = -5.0;
    double a,b,c;

    a = Math.sqrt(x);


    public static int Soma(int a, int b)
    {
        return a + b;
    }

    public static int Subtracao(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicacao(int a, int b)
    {
        return a * b;
    }

    public static double Divisao(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return (double)a / b;
    }
}