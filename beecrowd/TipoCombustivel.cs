using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());  

        string tipoCombustivel = "";  
        if (x == 1) {
            tipoCombustivel = "Alcool";
        } else if (x == 2) {
            tipoCombustivel = "Gasolina";
        } else if (x == 3) {
            tipoCombustivel = "Diesel";
        } 
        Console.WriteLine($"MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {y}");  
        Console.WriteLine($"Gasolina: {y}");
        Console.WriteLine($"Diesel: {y}"); 
        

    }

}