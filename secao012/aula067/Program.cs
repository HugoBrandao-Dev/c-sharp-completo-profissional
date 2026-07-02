namespace aula067;

class Program
{
    static void Main(string[] args)
    {
        Pessoa.maioridade = 21;

        Pessoa p1 = new Pessoa();
        p1.nome = "Tobias";
        p1.idade = Pessoa.CalcularIdade(1990);
        p1.Apresentar();
        
        Console.WriteLine(p1.nome);
        Console.WriteLine(p1.idade);
        Console.WriteLine(Pessoa.maioridade);

        Console.ReadKey();
    }
}