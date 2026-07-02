namespace aula066;

public static class Matematica
{
    public static float a, b, c;
    
    public static string DescreverParabola()
    {
        string msgConcav = "";
        string msgPosicao = "";
        string msgCorteY = "";

        // Verifica o a
        if (a > 0)
        {
            msgConcav = "cima";
        } else if (a < 0)
        {
            msgConcav = "baixo";
        }
        
        // Verifica o b
        if (b > 0)
        {
            msgPosicao = "esquerda";
        } else if (b < 0)
        {
            msgPosicao = "direita";
        }

        return "Concavidade para: " + msgConcav +
               "\nEstá à " + msgPosicao + "do eixo Y." +
               "\nCorta o eixo Y em " + c;
    }
    public static float Delta()
    {
        return b * b - 4 * a * c;
    }
}