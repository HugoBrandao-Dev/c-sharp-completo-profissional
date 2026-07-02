namespace aula065;

public class Pessoa
{
    public string nome;
    public string sobrenome;
    public int anoNascimento;
    public int idade;

    #region Sobrecarga de Construtor
    public Pessoa()
    {
        nome = "Desconhecido";
        sobrenome = "Nenhum";
        anoNascimento = 0;
        idade = 0;
    }

    // Sobrecarga para a setagem de valores.
    public Pessoa(string nome, string sobrenome, int anoNascimento)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.anoNascimento = anoNascimento;
        this.idade = Idade();
    }
    
    public Pessoa(string nome, string sobrenome)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.anoNascimento = 2008;
        this.idade = Idade();
    }
    #endregion

    private int Idade()
    {
        return 2026 - anoNascimento;
    }
}