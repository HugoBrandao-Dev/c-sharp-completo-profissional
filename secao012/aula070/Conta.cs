namespace aula070;

public class Conta
{
    private string _cliente;
    private float _saldo;
    private float _taxa = 1.05f;

    // Propriedades do Cliente
    public string Cliente
    {
        get { return _cliente; }
        set {
            if (value != "Tobias" && value != "Dinorá")
            {
                Console.WriteLine("\nCliente não encotrado.");
                _cliente = "Visitante";
                Saldo = 0;
            }
            else
            {
                _cliente = value;
                Saldo = 100;
            }

            Console.WriteLine("Acessando como: " + _cliente + ".");
        }
    }

    public float Saldo
    {
        get { return _saldo; }
        private set // Com o private só será possivel modificar o saldo dentro de Conta.
        {
            _saldo = value;
        }
    }

    public void Sacar(float valor)
    {
        if (_saldo - valor < 0)
        {
            _saldo = 0;
        }
        else
        {
            _saldo -= valor * _taxa; // Taxa de 5% no saque.
        }
    }

    public void Depositar(float valor)
    {
        _saldo += valor;
    }
}