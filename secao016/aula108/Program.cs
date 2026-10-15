using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula108
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string valor;
            int valorConvertido;

            Console.Write("Informe um valor qualquer: ");
            valor = Console.ReadLine();

            /*
            Não só retorna se é conversível, mas o valor já convertido é
            armazenado na variável passada como argumento (out <<VARIÁVEL>>).
            */
            if (int.TryParse(valor, out valorConvertido))
            {
                Console.WriteLine("O valor é conversível para inteiro e é " + valorConvertido);
            } else
            {
                Console.WriteLine("O valor NÃO é conversível para inteiro!!");
            }



            Console.ReadKey();

        }
    }
}
