using System.Diagnostics;

namespace aula070;

class Program
{
    static void Main(string[] args)
    {
        sbyte opcao;
        float valor;
        


        Conta c1 = new Conta();

        Console.Write("Informe seu nome: ");
        c1.Cliente = Console.ReadLine();

        do
        {
            Console.WriteLine("\nOpções");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Saldo atual");
            Console.WriteLine("0 - SAIR");
            Console.Write("> ");
            opcao = sbyte.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nObrigado por usar nosso sistema.");
                    break;
                case 1:
                    Console.Write("Quanto deseja depositar R$ ");
                    valor = float.Parse(Console.ReadLine());

                    if (valor > 0)
                    {
                        c1.Depositar(valor);
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido para depósito\n");
                        goto case 1;
                    }
                    break;
                case 2:
                    Console.Write("Quanto deseja sacar R$ ");
                    valor = float.Parse(Console.ReadLine());

                    if (valor > 0)
                    {
                        c1.Sacar(valor);
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido para saque\n");
                        goto case 2;
                    }
                    break;
                case 3:
                    Console.WriteLine("Cliente: " + c1.Cliente);
                    Console.WriteLine("Saldo: R$ " + c1.Saldo);
                    break;
            }
        } while (opcao != 0);

        Console.ReadKey();
    }
}