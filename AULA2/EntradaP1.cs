using System;

namespace AULA2
{
    class EntradaP1
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite uma frase e palavras: ");
            string frase = Console.ReadLine();
             string  x = Console.ReadLine();    
             string  y = Console.ReadLine();
            Console.WriteLine("A frase digitada foi: " + frase);
             Console.WriteLine("A frase digitada foi: " + x);
             Console.WriteLine("A frase digitada foi: " + y);

             string[] palavras = frase.Split(' ');
            Console.WriteLine("As palavras digitadas foram:");  
            string [] palavras1 = palavras[0];
            string [] palavras2 = palavras[1];
            string [] palavras3 = palavras[2];  

                Console.WriteLine(palavras1);
                Console.WriteLine(palavras2);
                Console.WriteLine(palavras3);

        }
    }
}