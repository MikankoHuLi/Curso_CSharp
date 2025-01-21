namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do A:");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do B:");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do C:");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoC))
            {
                Console.WriteLine("Os valores informados formam um triângulo");
            }
            else
            {
                Console.WriteLine("Os valores informado não formam um triângulo");
            }
            
                
             

        }
    }
}
