using System;

class URI {
    static void Main(string[] args) { 
        int t = int.Parse(Console.ReadLine());
        
       int primeiroLink = 0;
        for (int i = 0; i < t; i++) {
            string[] links = Console.ReadLine().Split(' ');
            int link1 = int.Parse(links[0]);
            int link2 = int.Parse(links[1]);

            if (link1 < link2) {
                primeiroLink = link1;
            } else {
                primeiroLink = link2;
            }
        }

        Console.WriteLine(primeiroLink);
    }
}