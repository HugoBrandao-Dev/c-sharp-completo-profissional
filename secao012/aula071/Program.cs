namespace aula071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro");
            Carro c1 = new Carro();
            c1.Marca = "Toyota";
            c1.Cor = "Branco";
            c1.LigarMotor();
            c1.Acelerar();

            Console.WriteLine("\nBicicleta");
            Bicicleta b1 = new Bicicleta();
            b1.Marca = "Mormaii";
            b1.Cor = "Azul";
            b1.Pedalar();
            b1.Acelerar();
        }
    }
}
