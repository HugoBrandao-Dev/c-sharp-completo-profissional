namespace aula066;

class Program
{
    static void Main(string[] args)
    {
        float a, b, c;
        
        Console.Write("Valor para a: ");
        Matematica.a = float.Parse(Console.ReadLine());
        
        Console.Write("Valor para b: ");
        Matematica.b = float.Parse(Console.ReadLine());
        
        Console.Write("Valor para c: ");
        Matematica.c = float.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine(Matematica.DescreverParabola());
        Console.WriteLine("Delta: " + Matematica.Delta());
        Console.ReadKey();
    }
}