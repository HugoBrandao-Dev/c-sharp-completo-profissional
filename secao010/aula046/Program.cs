using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace aula046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num;
            string msgNum;

            Console.Write("Informe um número (0 - 10): ");
            num = sbyte.Parse(Console.ReadLine());

            if (num >= 0 && num <= 10)
            {
                switch (num)
                {
                    case 0:
                        msgNum = "Zero";
                        break;
                    case 1:
                        msgNum = "Um";
                        break;
                    case 2:
                        msgNum = "Dois";
                        break;
                    case 3:
                        msgNum = "Três";
                        break;
                    case 4:
                        msgNum = "Quatro";
                        break;
                    case 5:
                        msgNum = "Cinco";
                        break;
                    case 6:
                        msgNum = "Seis";
                        break;
                    case 7:
                        msgNum = "Sete";
                        break;
                    case 8:
                        msgNum = "Oito";
                        break;
                    case 9:
                        msgNum = "Nove";
                        break;
                    case 10:
                        msgNum = "Dez";
                        break;
                    default:
                        msgNum = "????";
                        break;
                }
            } else
            {
                msgNum = "ERRO: Número fora do intervalo";
            }

            Console.WriteLine(msgNum);
            Console.ReadKey();
        }
    }
}
