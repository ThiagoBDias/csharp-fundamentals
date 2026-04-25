using System ;

namespace AULA2
{
    class Atividade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            string quartos = Console.ReadLine();
            Console.WriteLine("Você digitou: " + quartos); 
            Console.WriteLine("Entre com o preço de um produto:");
            string preco = Console.ReadLine(); 
            Console.WriteLine("Você digitou: " + preco);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);
            Console.WriteLine("Você digitou: " + ultimoNome + ", " + idade + " anos, " + altura + "m");


            int a,b,c ;
            
        
        }
    }
}