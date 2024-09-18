using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simulação dos interruptores
            bool[] interruptores = new bool[3]; 
            bool[] lampadasQuentes = new bool[3]; 
            bool[] lampadasAcesas = new bool[3]; 

            // Configuração dos interruptores
            interruptores[0] = true; 
                                     
            interruptores[0] = false; 
            interruptores[1] = true; 
            interruptores[2] = false; 

            // Simulamos as lâmpadas
            lampadasQuentes[0] = true; 
                                       
            lampadasAcesas[1] = true; 
                                      
            lampadasAcesas[2] = false; 

            // Exibir resultados
            for (int i = 0; i < 3; i++)
            {
                if (lampadasAcesas[i])
                {
                    Console.WriteLine($"Lâmpada {i + 1} está acesa e conectada ao Interruptor {(char)('A' + i)}");
                }
                else if (lampadasQuentes[i])
                {
                    Console.WriteLine($"Lâmpada {i + 1} está quente e conectada ao Interruptor {(char)('A' + i)}");
                }
                else
                {
                    Console.WriteLine($"Lâmpada {i + 1} está fria e apagada, conectada ao Interruptor {(char)('A' + i)}");
                }
            }
        }
    }
}