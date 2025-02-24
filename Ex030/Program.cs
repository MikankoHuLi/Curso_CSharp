﻿namespace Ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador(1, 10, 1);
            Contador(10, 0, 2);

            Escrever("Agora é hora da sua morte");

            Console.WriteLine("Digite o início da sua falência");
            int ini = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quanto tempo você vai agonizar");
            int final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quão rápido sua agonia vai acabar");
            int pass = Convert.ToInt32(Console.ReadLine());

            if (pass < 0)
            {
                pass = pass * -1;
            }

            Contador(ini, final, pass);

        }

        static void Contador(int inicio, int fim, int passo)
        {
            Escrever($"Contagem de {inicio} até {fim} de {passo} em {passo}");
            Thread.Sleep(2000);

            if (inicio < fim)
            {
                int cont = inicio;
                while (cont <= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont += passo;
                }
                Console.WriteLine("Fim");
            }
            else
            {
                int cont = inicio;
                while (cont >= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -= passo;
                }
                Console.WriteLine("Fim");
            }
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textocent = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textocent);
            Console.WriteLine(linha);
        }
    }
}
