using System;

class URI {
    static void Main(string[] args) { 
        int totalDias = int.Parse(Console.ReadLine());

        int anos = totalDias / 365;
        int meses = (totalDias % 365) / 30; 
        int dias = (totalDias % 365) % 30;
        


        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}