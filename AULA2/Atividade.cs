using System ;

namespace AULA2
{
    class Atividade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Você digitou: " + nome);
            Console.WriteLine("Quantos quartos tem na sua casa?");
            string quartos = Console.ReadLine();
            Console.WriteLine("Você digitou: " + quartos); 
            Console.WriteLine("Entre com o preço de um produto:");
            string preco = Console.ReadLine(); 
            Console.WriteLine("Você digitou: " + preco);
        }
    }
}