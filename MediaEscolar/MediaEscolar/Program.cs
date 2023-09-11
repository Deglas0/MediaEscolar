namespace MediaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno n = new Aluno();
            Console.WriteLine("Olá, vamos calcular a nota do aluno(a)?");
            Console.Write("Digite o nome do Aluno: ");
            n.Nome = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite a nota: " + (i + 1));
                n.Nota[i] = double.Parse(Console.ReadLine());
                if (i < 1)
                {
                    if (n.Nota[i] > 30)
                    {
                        Console.WriteLine("numero invalido, porfavor digitar novaente");
                        i--;
                    }
                    else
                    { Console.WriteLine($"nota {i} salva com sucesso..."); }
                }
                else
                {
                    if (n.Nota[i] > 35)
                    {
                        Console.WriteLine("numero invalido, porfavor digitar novaente");
                    }
                    else
                    { Console.WriteLine($"nota {i} salva com sucesso..."); }
                }
            }
            n.Conseito(n.Media());
        }
    }
}