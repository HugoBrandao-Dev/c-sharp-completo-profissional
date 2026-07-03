namespace aula069;

class Program
{
    static void Main(string[] args)
    {
        Teste t1 = new Teste();
        t1.Idade = 21;
        Console.WriteLine(t1.Nome);
        Console.WriteLine(t1.Idade);
        t1.BoasVindas();
        
        Console.WriteLine("==============================");
        
        Teste t2 = new Teste("Tobias", "Cruz");
        t2.Idade = 17;
        Console.WriteLine(t2.Nome);
        Console.WriteLine(t2.Idade);
        t2.BoasVindas();
    }
}