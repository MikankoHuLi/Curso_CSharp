namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media1, media2 ;

            Console.WriteLine("Digite sua primeira nota:");

            media1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota:");

            media2 = Convert.ToInt32(Console.ReadLine());
              
            Console.WriteLine("Sua Média é: {0}",(media1 + media2)/2);

        }
    }
}
