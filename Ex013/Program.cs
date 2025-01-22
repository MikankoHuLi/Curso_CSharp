namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Insira sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Faltam {0} anos para você se alistar", 18 - idade);
            }
            else if (idade > 18)
            {
                Console.WriteLine("Passarem-se {0} anos do seu alistamento", idade - 18);
            }
            else
            {
                Console.WriteLine("Está na hora de se alistar");
            }

        }
    }
}
