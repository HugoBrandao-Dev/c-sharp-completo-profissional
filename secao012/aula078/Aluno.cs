using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula078
{
    internal class Aluno
    {
        public string Nome { get; private set; }

        private float[] _notas;

        public float Media
        {
            get { return CalcularMedia(); }
        }

        public Aluno(string nome, ushort provas)
        {
            Nome = nome;
            _notas = new float[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = float.Parse(Console.ReadLine());
            }
        }

        private float CalcularMedia()
        {
            float total = 0;

            foreach (float nota in _notas)
            {
                total += nota;
            }

            return total / _notas.Length;
        }
    }
}
