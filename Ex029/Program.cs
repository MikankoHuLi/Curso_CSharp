namespace Ex029
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new ('=', tam);
            string textocent = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textocent);
            Console.WriteLine(linha);
        }


        static void Main(string[] args)
        {
            Escrever("Guilherme Diniz Correa");
            Console.WriteLine();
        }
    }
}
