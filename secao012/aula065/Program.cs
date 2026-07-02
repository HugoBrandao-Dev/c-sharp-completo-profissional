namespace aula065;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Tobias", "de Oliveira", 1990);
        Console.WriteLine("#1 Pessoa:");
        Console.WriteLine(p1.nome);
        Console.WriteLine(p1.sobrenome);
        Console.WriteLine(p1.anoNascimento);
        Console.WriteLine(p1.idade);

        Pessoa p2 = new Pessoa("Doralice", "Cruz");
        Console.WriteLine("\n#2 Pessoa:");
        Console.WriteLine(p2.nome);
        Console.WriteLine(p2.sobrenome);
        Console.WriteLine(p2.anoNascimento);
        Console.WriteLine(p2.idade);

        Console.ReadKey();
    }
}