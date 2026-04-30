using System;
using System.Collections.Generic;

class URI {
    static List<int> primos = new List<int>();

    static void GerarPrimos() {
        int limite = 35000; 
        bool[] ehPrimo = new bool[limite + 1];
        
        for (int i = 2; i <= limite; i++) ehPrimo[i] = true;

        for (int p = 2; p * p <= limite; p++) {
            if (ehPrimo[p]) {
                for (int i = p * p; i <= limite; i += p)
                    ehPrimo[i] = false;
            }
        }

        for (int p = 2; p <= limite; p++) {
            if (ehPrimo[p]) {
                primos.Add(p);
            }
        }
    }

    static void Main(string[] args) { 
        GerarPrimos(); 

        while (true) {
            string entrada = Console.ReadLine();
            if (string.IsNullOrEmpty(entrada)) break;

            int n = int.Parse(entrada);
            
            if (n == 0) break;

            List<int> pessoas = new List<int>();
            for (int i = 1; i <= n; i++) {
                pessoas.Add(i);
            }

            int indiceAtual = 0;
            
            for (int i = 0; i < n - 1; i++) {
                int salto = primos[i]; 
                
                indiceAtual = (indiceAtual + salto - 1) % pessoas.Count;
                
                pessoas.RemoveAt(indiceAtual);
            }

            Console.WriteLine(pessoas[0]);
        }
    }
}