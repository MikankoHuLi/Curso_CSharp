namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gen;
            Console.Write("Digite o seu gênero: ");
            gen = Console.ReadLine().ToUpper();

            while (gen != "F" && gen != "M" && gen != "NB") 
            {
                Console.Write("Digite o seu gênero: ");
                gen = Console.ReadLine();
            }
            Console.Write("Bem-Vindes ao curso de C#");
        }
    }
}
