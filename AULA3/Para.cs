using System ;

namespace AULA3
{
    class para  
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            int n = int.Parse(Console.ReadLine());

            soma = 0;  

            for (int i = 0; i < n; i++)
            {
               x = int.Parse(Console.ReadLine());
               soma += x;
               
            }
            
        
        }
    }
}