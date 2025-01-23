namespace Ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user;
            Console.Write("Digite um número: ");
           user = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", user, i, user * i);
            }
        }
    }
}
