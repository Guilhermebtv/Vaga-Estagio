using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sequência a)
            int a = 1;
            Console.WriteLine($"Próximo elemento da sequência a) 1, 3, 5, 7, ___ é {(a + 2) * 3}"); 

            // Sequência b)
            int b = 64;
            Console.WriteLine($"Próximo elemento da sequência b) 2, 4, 8, 16, 32, 64, ____ é {b * 2}"); 

            // Sequência c)
            int c = 36;
            Console.WriteLine($"Próximo elemento da sequência c) 0, 1, 4, 9, 16, 25, 36, ____ é {((int)Math.Sqrt(c) + 1) * ((int)Math.Sqrt(c) + 1)}"); 

            // Sequência d)
            int d = 64;
            Console.WriteLine($"Próximo elemento da sequência d) 4, 16, 36, 64, ____ é {((int)Math.Sqrt(d) + 2) * ((int)Math.Sqrt(d) + 2)}"); 

            // Sequência e)
            int e1 = 8;
            int e2 = 5; 
            Console.WriteLine($"Próximo elemento da sequência e) 1, 1, 2, 3, 5, 8, ____ é {e1 + e2}"); 

            // Sequência f)
            int f = 19;
            Console.WriteLine($"Próximo elemento da sequência f) 2, 10, 12, 16, 17, 18, 19, ____ é {f + 1}"); 
        }
    }
}