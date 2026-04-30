using System; 
using System.Globalization;

class URI {
    static void Main(string[] args) { 
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
     
        double n = 3.14159;
        double area = 0;
     
        string entrada = Console.ReadLine();
        
        if (entrada != null) {
            double raio = double.Parse(entrada.Trim());
            area = n * (raio * raio);
        }
        
        Console.WriteLine("A =" + area.ToString("F4"));
    }
}