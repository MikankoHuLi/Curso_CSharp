namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write("Digite a nota final do aluno:");
            nota_final = Convert.ToDouble(Console.ReadLine());

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "aprovado com louvor";
                }
                else
                {
                    resultado = "aprovado";
                }
                
            }
            
            else
            {
                if (nota_final >= 40)
                {
                    resultado = "recuperação";
                }
                else
                {
                    resultado = "reprovado";
                }
            }
            Console.WriteLine("Nota do Aluno {0} - Resultado {1}.", nota_final, resultado); 
        }
    }
}
