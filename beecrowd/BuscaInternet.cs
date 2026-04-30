using System;

class URI {
    static void Main(string[] args) { 
        int t = int.Parse(Console.ReadLine());
        
        int segundoLink = t * 2;
        int primeiroLink = segundoLink * 2;

        Console.WriteLine(primeiroLink);
    }
}