namespace Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
