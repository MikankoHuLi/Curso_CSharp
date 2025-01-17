namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string resultado;

                Console.Write("Digite um número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 ==0)
            {
                resultado = "Par";
            }
            else
            {
                resultado = "Ímpar";
            }
            Console.Write("Ele é {0}", resultado);
        }
    }
}
