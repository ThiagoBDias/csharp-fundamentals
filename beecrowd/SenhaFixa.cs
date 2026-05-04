using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        int senhaFixa = 2002;
        int senha = int.Parse(Console.ReadLine());  
        while (senha != senhaFixa) {
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");  
        
        

    }

}