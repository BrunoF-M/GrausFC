using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double ansF;
            double resC;

            Console.ForegroundColor=ConsoleColor.DarkGreen;

            Console.WriteLine("Olá digite um grau em Fahrenheit para saber em Celsius");
            Console.WriteLine();

            Console.ResetColor();


            Console.Write("digite os Graus em Fahrenheit °F aqui: ");
            ansF = double.Parse(Console.ReadLine());


            resC = (ansF -32) / 1.8;

            Console.ForegroundColor=ConsoleColor.DarkGreen;

            Console.WriteLine();
            Console.WriteLine($"Conversão para Celsius = {resC}°C");
            
            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("Aperte qualquer tecla para Finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
