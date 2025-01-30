namespace Ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Guilherme");
            Soma(1, 99);
        }

        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, seja Bem-Vindo");
        }

        static void Soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");//$ facilta processo ao nomear variaveis
            // Console.WriteLine("A soma de {0} + {1} é igual a {2}.", a, b, resultado); forma usada anteriormente

        }

    }
}
