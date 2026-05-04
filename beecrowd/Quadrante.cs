using System;

class URI {
    static void Main(string[] args) {
        
        while (true) {
            // Lê a linha e separa os valores pelo espaço em branco
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            // Se pelo menos uma das coordenadas for nula (0), encerra o algoritmo sem imprimir nada
            if (x == 0 || y == 0) {
                break;
            }

            // Verificação dos quadrantes
            if (x > 0 && y > 0) {
                Console.WriteLine("primeiro");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("segundo");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("terceiro");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("quarto");
            }
        }
    }
}