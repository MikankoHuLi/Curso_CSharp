namespace Ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em qual ano você nasceu? ");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(Voto(nasc));

        }

        static string Voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            //int anoAtual = dataAtual.Month .Day . Hour . Minute . Second
            int idade = anoAtual - ano;

            if (idade < 16)
            {
                return $"Com {idade} anos: Você não vota.";
            }

            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos: Você vota.";
            }
            
            else
            {
                return $"Com {idade} anos: Seu voto é opcional.";
            }

        }
    }
}
