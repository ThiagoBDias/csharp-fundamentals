using System;

class URI {
    static void Main(string[] args) {
        
        // 1. Cria os contadores zerados
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        // 2. Cria o laço de repetição contínuo
        while (true) {
            // Lê apenas um código por vez dentro do laço
            int codigo = int.Parse(Console.ReadLine());

            // 3 e 4. Verifica o código e soma no contador correto ou encerra
            if (codigo == 1) {
                alcool++;
            } else if (codigo == 2) {
                gasolina++;
            } else if (codigo == 3) {
                diesel++;
            } else if (codigo == 4) {
                break; // O código 4 encerra o laço
            }
            // Qualquer outro número é ignorado e o laço repete
        }

        // 5. Imprime o resultado final fora do laço
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}