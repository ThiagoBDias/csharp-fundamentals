using System;

class URI {
    static void Main(string[] args) { 
        int T = int.Parse(Console.ReadLine());
        string[] respostas = Console.ReadLine().Split(' ');

        int acertos = 0;
        for (int i = 0; i < T; i++)   {
            string resposta = respostas[i];
            if (resposta == "1" || resposta == "4" || resposta == "78") {
                acertos++;
            }
        }

        Console.WriteLine(acertos);
    }
}