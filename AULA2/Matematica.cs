using System;

public class Matematica
{
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