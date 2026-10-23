using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula116
{
    internal class Program
    {
        public static Dictionary<int, string> items = new Dictionary<int, string>();

        private static void MostrarMenu()
        {
            Console.WriteLine("OPÇÕES:" +
                "\n[1] - Adicionar valor;" +
                "\n[2] - Buscar primeiro valor;" +
                "\n[3] - Buscar último valor;" +
                "\n[4] - Verificar existência de chave;" +
                "\n[5] - Verificar existência de valor;" +
                "\n[0] - SAIR.");
        }

        private static void NovaChaveValor()
        {

            string nome;
            sbyte chave;

            Console.Write("Chave: ");
            if (sbyte.TryParse(Console.ReadLine(), out chave))
            {
                // Se não há uma chave
                if (!items.ContainsKey(chave))
                {

                    Console.Write("Nome: ");
                    nome = Console.ReadLine();

                    items.Add(chave, nome);

                }
            } else
            {
                Console.WriteLine("--- Erro: O valor da chave é inválido.");
            }          

        }

        private static void BuscarPrimeiroValor()
        {

            Console.WriteLine("Primeiro valor: " + items.First().Value);

        }
        
        private static void BuscarUltimoValor()
        {

            Console.WriteLine("Último valor: " + items.Last().Value);

        }
        
        private static void ExisteChave()
        {

            sbyte chave;

            Console.Write("Chave:\n> ");
            if (sbyte.TryParse(Console.ReadLine(), out chave))
            {
                
                if (items.ContainsKey(chave))
                {
                    Console.WriteLine("A chave existe");
                } else
                {
                    Console.WriteLine("A chave NÃO existe");
                }

            } else
            {
                Console.WriteLine("--- Erro: Valor da chave é inválido.");
            }

        }

        private static void ExisteValor()
        {

            string valor;

            Console.Write("Valor:\n> ");
            valor = Console.ReadLine();

            if (items.ContainsValue(valor))
            {
                Console.WriteLine("O valor existe!");

            } else
            {
                Console.WriteLine("O valor NÃO existe!");
            }

        }
        
        private static void ExecutarOpcao(sbyte opcao)
        {
            Console.Clear();
            switch (opcao)
            {
                case 0:
                    Console.WriteLine("SAIU");
                    break;
                case 1:
                    NovaChaveValor();
                    break;
                case 2:
                    BuscarPrimeiroValor();
                    break;
                case 3:
                    BuscarUltimoValor();
                    break;
                case 4:
                    ExisteChave();
                    break;
                case 5:
                    ExisteValor();
                    break;
                default:
                    Console.WriteLine("--- Erro: A Opção não existe");
                    break;
            }
        }

        static void Main(string[] args)
        {

            sbyte opcaoMenu;

            do
            {

                MostrarMenu();
                opcaoMenu = sbyte.Parse(Console.ReadLine());
                ExecutarOpcao(opcaoMenu);

            } while (opcaoMenu != 0);

            Console.ReadKey();

        }
    }
}
