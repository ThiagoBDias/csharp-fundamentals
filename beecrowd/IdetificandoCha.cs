using System;

class URI {
    static void Main(string[] args) { 
        int T = int.Parse(Console.ReadLine());
        string[] respostas = Console.ReadLine().Split(' ');

        int acertos = 0;
        foreach (string r in respostas) {
            if (int.Parse(r) == T) {
                acertos++;
            }
        }

        Console.WriteLine(acertos);
    }
}