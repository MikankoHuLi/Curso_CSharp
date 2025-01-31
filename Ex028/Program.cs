namespace Ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Área do Triângulo");
            Console.WriteLine("-----------------");

            Console.WriteLine("Digite o tamanho da base do triângulo");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triângulo");
            double alt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Area(Base, alt);
        }

        static void Area(double Base, double alt)
        {
            double area = (Base * alt) / 2;
            Console.WriteLine($"A área do triângulo de base de {Base} e altura de {alt} é igual {area}. ");
        }
    }
}
