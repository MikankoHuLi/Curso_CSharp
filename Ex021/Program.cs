namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadig;

            do
            {
                Console.Write("Digite a senha: ");
                senhadig = Console.ReadLine();
            } while (senhadig != senha);

            Console.Write("Senha Correta");


        }
    }
}
