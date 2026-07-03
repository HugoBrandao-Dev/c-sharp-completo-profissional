namespace aula069;

public class Teste
{
    public Teste()
    {
        Nome = "Desconhecido";
        _sobrenome = "Nenhum";
    }
    public Teste(string nome, string sobrenome)
    {
        Nome = nome;
        _sobrenome = sobrenome;
    }
    
    public string Nome { get; set; }
    private string _sobrenome;
    
    /*
    Essa propriedade não poderá ser usada, nem dentro desta mesma classe,
    por não possuir get.
    */
    /*
    public string Sobrenome
    {
        set { Sobrenome = value; }
    }
    */
    
    private int _idade;
    public int Idade
    {
        get
        {
            return _idade;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Menor de idade. Impossível usar esse valor");
            }
            else
            {
                _idade = value;
            }
        }
    }

    public void BoasVindas()
    {
        Console.WriteLine("Seja bem vindo, Sr(a) " + _sobrenome + ".");
    }
}