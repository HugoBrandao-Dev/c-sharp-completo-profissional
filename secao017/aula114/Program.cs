using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aula114
{
    internal class Program
    {
        private static HashSet<string> nomes = new HashSet<string>();
        private static List<string> nomesTemp = new List<string>();

        static void addValor()
        {

            string valor;

            do
            {
                Console.Write("> ");
                valor = Console.ReadLine();

                if (nomes.Contains(valor))
                {
                    Console.WriteLine("O valor já existe. Digite novamente: ");
                }

            } while (!nomes.Add(valor));

        }

        static void listarValores()
        {
            if (nomes.Count > 0)
            {

                foreach (string n in nomes)
                {
                    Console.WriteLine(n);
                }

            } else
            {
                Console.WriteLine("Seu HashSet está vazio!!");
            }
            
        }
        
        static void buscarValor()
        {
            
            string valor = Console.ReadLine();
            bool hasValor = nomes.Contains(valor);

            Console.WriteLine(hasValor ? "Sim" : "Não");

        }
        
        static void removerValor()
        {
            string valor;

            Console.Write("> ");
            valor = Console.ReadLine();

            if (!nomes.Remove(valor))
            {
                Console.WriteLine("O nome não existe!!");
            }

        }

        static void buscarValorPeloIndice()
        {

            int indice;
            string valor;

            Console.Write("> ");
            int.TryParse(Console.ReadLine(), out indice);

            if (indice >= 0 && indice < nomes.Count)
            {
                valor = nomes.ElementAt(indice);
                Console.WriteLine(valor);
            }
            else
            {
                Console.WriteLine("--- Não há valores para este índice");
            }

        }

        private static void buscarPrimeiroElemento()
        {

            if (nomes.Count > 0)
            {

                Console.WriteLine(nomes.First());

            } else
            {
                Console.WriteLine("--- Erro: HashSet vazio.");
            }

        }

        private static void buscarUltimoElemento()
        {

            if (nomes.Count > 0)
            {

                Console.WriteLine(nomes.Last());

            } else
            {
                Console.WriteLine("--- Erro: HashSet vazio");
            }
        }

        private static void mostrarMenu()
        {
            Console.WriteLine("OPÇÕES:" +
                "\n[1] - Adicionar um valor;" +
                "\n[2] - Listar valores" +
                "\n[3] - Verificar se existe um valor;" +
                "\n[4] - Remover um valor;" +
                "\n[5] - Valor em um índice;" +
                "\n[6] - Primeiro elemento;" +
                "\n[7] - Último elemento;" +
                "\n[0] - SAIR");
        }

        static void selecionarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    addValor();
                    break;
                case 2:
                    listarValores();
                    break;
                case 3:
                    buscarValor();
                    break;
                case 4:
                    removerValor();
                    break;
                case 5:
                    buscarValorPeloIndice();
                    break;
                case 6:
                    buscarPrimeiroElemento();
                    break;
                case 7:
                    buscarUltimoElemento();
                    break;
                default:
                    Console.WriteLine("--- Erro: A opção não existe");
                    break;
            }
        }
        
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                mostrarMenu();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                selecionarOpcao(opcao);

            } while (opcao != 0);

            Console.WriteLine("SAIU!! - Pressione uma tecla");
            Console.ReadKey();

        }
    }
}
