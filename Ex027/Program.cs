﻿namespace Ex027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Controle de Terrenos");
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.Write("Digite a largura do tereno em metros: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do tereno em metros: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            AreaTerreno(largura, comprimento);

        }

        static void AreaTerreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A área do terrno de {l}m x {c}m é de {a:F2}m².");
        }
    }
}
