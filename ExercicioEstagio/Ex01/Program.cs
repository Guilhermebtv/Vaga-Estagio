using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se ele pertence à sequência de Fibonacci: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsFibonacci(number))
                {
                    Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static bool IsFibonacci(int num)
        {
            if (num == 0 || num == 1)
            {
                return true;
            }

            int a = 0;
            int b = 1;

            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == num;
        }
    }
}