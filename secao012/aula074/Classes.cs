namespace aula074;

public class Humano
{
    public virtual void Olhos()
    {
        Console.WriteLine("Humano.Olhos");
    }

    public virtual void Cabelos()
    {
        Console.WriteLine("Humano.Cabelos");
    }
}

public class Pessoa : Humano
{
    public sealed override void Olhos()
    {
        Console.WriteLine("Pessoa.Olhos");
    }

    public override void Cabelos()
    {
        Console.WriteLine("Pessoa.Cabelos");
    }
}

public class Homem : Pessoa
{
    /*
     Esse metodo, na classe Pessoa, esta marcado com sealed
    public override void Olhos()
    {
        Console.WriteLine("Homem.Olhos");
    }
    */

    public override void Cabelos()
    {
        Console.WriteLine("Homem.Cabelos");
    }
}