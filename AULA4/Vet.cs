using System ;

namespace AULA4
{
    class vet
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valores digitados:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }
            
            string[] strings = Console.ReadLine().Split(' ');
            Console.WriteLine("Strings digitadas:");
            for (int i = 0; i < strings.Length; i++)    
            {
                vet[i] = int.Parse(strings[i]);
            }     
            for (int i = 0; i <n; i++)
            {
                if(vet[i] < 0)
                {
                   Console.WriteLine(vet[i]);
                }
            }
            
        
        }
    }
}