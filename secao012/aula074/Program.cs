namespace aula074;

class Program
{
    static void Main(string[] args)
    {
        Humano hu1 = new Humano();
        hu1.Olhos();
        hu1.Cabelos();
        
        Console.WriteLine();
        
        Pessoa p1 = new Pessoa();
        p1.Olhos();
        p1.Cabelos();

        Console.WriteLine();
        
        Homem ho1 = new Homem();
        ho1.Olhos();
        ho1.Cabelos();

        Console.ReadKey();
    }
}