namespace Ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, alt, imc;

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            alt = Convert.ToDouble(Console.ReadLine());

            imc = peso / (alt * alt);
            //Console.WriteLine("IMC: {0:F2}",imc);
            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC é de {0:F2} e está abaixo do peso.", imc);
            }

            else if (imc < 25)
            {
                Console.WriteLine("Seu IMC é de {0:F2} e está no peso ideal.", imc);
            }

            else if (imc < 30)
            {
                Console.WriteLine("Seu IMC é de {0:F2} e está em sobrepeso.", imc);
            }

            else if (imc < 40)
            {
                Console.WriteLine("Seu IMC é de {0:F2} e está em obesidade.", imc);
            }

            else
            {
                Console.WriteLine("Seu IMC é de {0:F2} e está em obesidade mórbida.", imc);
            }


        }
    }
}
