namespace Ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", 
                "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + " dias");    
            }

            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            foreach ( string dia in semana)
            {
                Console.WriteLine(dia);
            }
            */

            int[] num = { 10, 45, 22, 50, 6, -84, -2, 91, -23 };
            

            Console.WriteLine(num.First());
            Console.WriteLine(num.Last());
            Console.WriteLine();
            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());
            Console.WriteLine();
            Console.WriteLine(num.Average());
           


        }
    }
}
