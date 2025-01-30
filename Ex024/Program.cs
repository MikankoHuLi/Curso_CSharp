namespace Ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "banana", "melancia", "pitaya", "kiwi", "carambola",
                "fruta antiga", "morango", "mirtilo", "lichia", "pêssego" };
            double[] precos = { 10, 38.40, 88.50, 7, 56.20, 33, 42, 11.99, 9.99, 10.50 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + frutas[i] + " é R$ " + precos[i]);
                
            }
            Console.WriteLine();
            Console.WriteLine("O maior preço é R$ " + precos.Max());
            Console.WriteLine("O menor preço é R$ " + precos.Min());
            Console.WriteLine("A média dos preços é R$ " + precos.Average());

        }
    }
}
