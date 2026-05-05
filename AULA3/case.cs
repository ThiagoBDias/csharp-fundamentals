using System ;

namespace AULA3
{
    class para  
    {
        static void Main(string[] args)
        {
            int n, y ;
            n = int.Parse(Console.ReadLine());  
            y = 1;  
            
            while (y <= n)
            {
                Console.WriteLine(y);
                y = y + 1;  
            }  
            
        }
    }
}