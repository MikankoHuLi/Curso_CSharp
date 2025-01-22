using System.Runtime.InteropServices;

namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Insira um número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira um segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O segundo número é maior");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais");
            }

        }
    }
}
