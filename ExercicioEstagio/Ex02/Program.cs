using System;
using System.Linq;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string para verificar a quantidade de letras 'a' (maiúsculas ou minúsculas): ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("A string fornecida é nula.");
                return;
            }

            int count = input.ToLower().Count(c => c == 'a');

            Console.WriteLine($"A letra 'a' aparece {count} vezes na string."); 
        }
    }
}