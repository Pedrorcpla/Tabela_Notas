using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2_25._09
{
    class Program
    {
        public struct Aluno
        {
            public string[] nome;
            public double[,] nota;
            public double[] media;
            
        }
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno.nome = new string[15];
            aluno.nota = new double[15, 3];
            aluno.media = new double[15];
            int l, c;

            for (l = 0; l < 15; l++)
            {
                Console.WriteLine("Nome do aluno: ");
                aluno.nome[l] = Console.ReadLine();
                for (c = 0; c < 3; c++)
                {
                    Console.Write("Nota {0}: ", c + 1);
                    aluno.nota[l, c] = double.Parse(Console.ReadLine());
                }
                Console.Clear();
            }
            for (l = 0; l < 15; l++)
            {
                aluno.media[l] = (aluno.nota[l, 0] + aluno.nota[l, 1] + aluno.nota[l, 2]) / 3;
            }
            Console.WriteLine("   NOME   |    NOTA    |MEDIA");
            Console.WriteLine("__________|____________|______");
            for (l = 0; l < 15; l++)
            {
                if (aluno.media[l] >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0,10}|{1,4}|{2,4}|{3,4}|{4,5}", aluno.nome[l], aluno.nota[l, 0], aluno.nota[l, 1], aluno.nota[l, 2], aluno.media[l]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0,10}|{1,4}|{2,4}|{3,4}|{4,5}", aluno.nome[l], aluno.nota[l, 0], aluno.nota[l, 1], aluno.nota[l, 2], aluno.media[l]);
                }
            }
            Console.ReadKey();
        }
    }
}
