using System;

class URI {
    static void Main(string[] args) {
        

        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

      
        while (true) {
           
            int codigo = int.Parse(Console.ReadLine());

            
            if (codigo == 1) {
                alcool++;
            } else if (codigo == 2) {
                gasolina++;
            } else if (codigo == 3) {
                diesel++;
            } else if (codigo == 4) {
                break; 
            }
            
        }

        
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}