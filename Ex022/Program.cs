namespace Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            //num[5] = 60; erro, passou dos limites do vetor (ah é)

            Console.WriteLine(num[4]);

            int[] n = new int[5] { 60, 70, 80, 90, 100 };

            Console.WriteLine(n[4]);

            int[] numero = { 65, 25, 84, 74, 12, 8 };

            Console.WriteLine(numero[4]);
            

            Random random = new Random();

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = random.Next(1, 100);
                Console.WriteLine(vetor[i]);
                
            }
            Console.WriteLine();

            double[] reais = new double[10];

            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 10000;// vezes para mudar o posicionamento da virgula
                Console.WriteLine(reais[i].ToString("P2"));//f2 duas casas decimais , f3 sao 3 e etc n2 aparece ponto do milhar c2 milhar e sifrao de dinheiro de acordo com windows E2 notacao cien P2 porcen
            }
            */

            string[] nomes = {"Maria",  "Carlos", "Pedro", "Ana", "José","Shadow" };
            for (int i = 0; i < nomes.Length ; i++)
            {
                if (i < nomes.Length - 1) 
                {
                    Console.Write(nomes[i] + ", ");
                }

                else
                {
                    Console.Write(nomes[i] + ".");
                }
               
                
            }


        }
    }
}
