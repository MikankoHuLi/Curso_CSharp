namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // senha correta
            string senhadig; // senha digitada pelo user
            int tentativas = 0; // contador tentativas

            // loop para solicitar senha usuário
            do 
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhadig = Console.ReadLine();
                tentativas ++; //incrementa contador tentativas

                if (senhadig != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha Incorreta");
                    Console.WriteLine("Você tem ainda tem " + (3 - tentativas) + " tentativa(s)");
                    Console.ReadKey(); 
                }

                else if (senhadig != senha && tentativas == 3)
                {
                    Console.WriteLine("Senha Incorreta - Seu acesso está bloqueado");
                    return;
                }

            } while (senhadig != senha);

            Console.Clear();
            Console.Write("Senha Correta - Tentativas: " + tentativas);


        }
    }
}
