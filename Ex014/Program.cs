namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc, atual;

            Console.Write("Digite o ano do seu nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano atual: ");
            atual = Convert.ToInt32(Console.ReadLine());

            if (atual - nasc < 9)
            {
                Console.Write("Você pertence a categoria Mirim");
            }
            else if (atual - nasc < 14)
            {
                Console.Write("Você pertence a categoria Infantil");
            }
            else if (atual - nasc < 19)
            {
                Console.Write("Você pertence a categoria Júnior");
            }
            else if (atual - nasc < 25)
            {
                Console.Write("Você pertence a categoria Sênior");
            }
            else
            {
                Console.Write("Você pertence a categoria Master");
            }
        }
    }
}
