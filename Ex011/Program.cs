namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double casa, sal, ano;

            Console.Write("Digite o valor da casa:");
            casa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu salário:");
            sal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite em quantos anos você pretende pagar:");
            ano = Convert.ToDouble(Console.ReadLine());

            if (casa / (ano * 12) < sal * 0.3)
            {
                Console.Write("O empréstimo foi aprovado");
            }

            else
            {
                Console.Write("O empréstimo foi reprovado, foa a prestação mensal no valor de {0} reais ultrapassa 30% do seu salário", casa / (ano * 12));
            }

      
            

        }
    }
}
