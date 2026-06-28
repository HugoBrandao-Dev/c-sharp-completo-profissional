using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            string msgFaixa = "\n";

            Console.WriteLine("=> CÁLCULO DE IMC <=\n");

            // O codigo abaixo e para entrada de dados.
            Console.Write("Informe seu peso (kg): ");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Informe sua altura (m): ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            // O codigo abaixo mostra o resultado do calculo do IMC.
            Console.WriteLine();
            Console.WriteLine("ALTURA: [" + altura + "m]");
            Console.WriteLine("PESO: [" + peso + "kg]");
            Console.WriteLine("--------------------------");
            Console.WriteLine("IMC: [" + imc + "kg/m²]");

            // O codigo abaixo mostra em qual faixa o usuario se encontra.
            if (imc < 18.5)
            {
                msgFaixa += "Abaixo do peso normal.";
            }
            else if (imc < 25)
            {
                msgFaixa += "Peso normal.";
            }
            else if (imc < 30)
            {
                msgFaixa += "Excesso de peso";
            }
            else if (imc < 35)
            {
                msgFaixa += "Obesidade classe I";
            }
            else if (imc < 40)
            {
                msgFaixa += "Obesidade classe II";
            }
            else
            {
                msgFaixa += "Obesidade class III";
            }

            Console.WriteLine(msgFaixa);
            Console.ReadKey();
        }
    }
}
