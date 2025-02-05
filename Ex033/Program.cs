namespace Ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool mostrar = false;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Você gostaria de ver o resultado? (n/s)");
            string resp = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (resp == "s")
            {
                mostrar = true;
            }

            Console.WriteLine(fatorial(num, mostrar));
        }

        static int fatorial(int n, bool show = false)
        {
            int resp = 1;

            for (int i = n; i > 0; i--)
            {
                if (show)
                {
                    Console.Write(i + " ");

                    if (i > 1)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("= ");
                    }
                }
                resp *= i;
            }

            return resp;
            
        }
    }
}
