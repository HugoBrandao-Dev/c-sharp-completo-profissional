namespace aula068;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Valor de a: ");
        Matematica.a = float.Parse(Console.ReadLine());
        
        Console.Write("Valor de b: ");
        Matematica.b = float.Parse(Console.ReadLine());
        
        Console.Write("Valor de c: ");
        Matematica.c = float.Parse(Console.ReadLine());
        
        Console.WriteLine("\nDelta: " + Matematica.Delta());

        Console.ReadKey();
    }
}