namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, num5;

            Console.WriteLine("Digite um número pfvr");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número, eu sei que você quer");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1 + num2;
            Console.WriteLine("a soma de {0} + {1} é igual a {2}.", num1, num2, num3);
            num3 = num1 - num2;
            Console.WriteLine("a subtração de {0} - {1} é igual a {2}.", num1, num2, num3);
            num3 = num1 * num2;
            Console.WriteLine("a multiplicação de {0} * {1} é igual a {2}.", num1, num2, num3);
            num3 = num1 / num2;
            Console.WriteLine("a divisão de {0} / {1} é igual a {2}.", num1, num2, num3);
            num3 = num1 % num2;
            Console.WriteLine("o resto da divisão de {0} / {1} é igual a {2}.", num1, num2, num3);

            num4 = 35f;
            num5 = num1 / num4;

            Console.WriteLine("a divisão exata de {0} / {1} é igual a {2}.", num1, num4, num5);







        }
    }
}
