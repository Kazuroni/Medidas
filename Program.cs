using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valormetros;
            
            Console.Write("digite um valor em Metro(s): ");
            valormetros = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("= = = Equivalêcia = = =");
            Console.ResetColor();

            Console.WriteLine($"{valormetros * 100} cm");
            Console.WriteLine($"{valormetros} m");
            Console.WriteLine($"{valormetros / 1000} Km");

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para Finalizar...");
            Console.ReadKey();
        }
    }
}
