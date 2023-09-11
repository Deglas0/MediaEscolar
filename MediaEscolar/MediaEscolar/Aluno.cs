using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEscolar
{
    internal class Aluno
    {
        public string Nome;
        public double[] Nota = new double[3];
        public double Media() {
            double medial = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"nota {i+1} = {Nota[i]}");
                medial += Nota[i];
            }
                return medial;
        }

        public void Conseito(double x) {
            double y = x - 60;
            if (y >= 0) 
            {
                Console.WriteLine($"Nota final {x.ToString("f2")} \n" +
                                  $"APROVADO");
            }
            else { Console.WriteLine($"Nota final {x}\n" +
                                     $"REPROVADO \n" +
                                     $"Faltaram {Math.Abs(x - 60).ToString("f2")} ");}
        }

    }

}

