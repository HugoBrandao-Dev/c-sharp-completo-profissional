using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "=> MÉDIA GERAL DOS ALUNOS <=";

            int qtdAlunos;

            Aluno[] alunos;

            Console.Write("Quantos alunos deseja cadastrar? ");
            qtdAlunos = int.Parse(Console.ReadLine());
            alunos = new Aluno[qtdAlunos];

            Console.WriteLine();

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                ushort provas = ushort.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            float mediaGeral = 0;
            
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Média: " + aluno.Media);

                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            float resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média geral dos alunos: " + resultadoFinal);

            Console.ReadKey();
        }
    }
}
