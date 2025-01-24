namespace Ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opcao = 0;

            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Novos Números");
                Console.WriteLine("5 - Sair do Programa");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        n3 = n1 + n2;
                        Console.WriteLine("A soma de {0} + {1} é {2} ", n1, n2, n3);
                        break;

                    case 2:
                        n3 = n1 - n2;
                        Console.WriteLine("A subtração de {0} - {1} é {2} ", n1, n2, n3);
                        break;

                    case 3:
                        n3 = n1 * n2;
                        Console.WriteLine("A multiplicação de {0} X {1} é {2} ", n1, n2, n3);
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                      
                        Console.Write("Saindo...");
                        break;

                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }
            }


        }
    }
}
