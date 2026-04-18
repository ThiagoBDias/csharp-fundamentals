using System;

namespace AULA2
{
    class EntradaP2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + numero);
        }
    }
}