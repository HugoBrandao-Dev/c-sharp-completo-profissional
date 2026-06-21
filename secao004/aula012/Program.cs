namespace aula012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inteiro com sinal
            sbyte meuSByte = 20; // 8 bits, de -128 a 127
            short meuShort = -30; // 16 bits, de -32.768 a 32.767
            int meuInt = 55; // 32 bits, de -2.147.483.648 a 2.147.483.647
            long meuLong = -30000; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.865.775.807
            #endregion

            #region Inteiro sem sinal
            byte meuByte = 15; // 8 bits, de 0 a 255
            ushort meuUshort = 21; // 16 bits, de 0 a 65.535
            uint meuUint = 11; // 32 bits, de 0 a 4.294.967.295
            ulong meuUlong = 1000000L; // 64 bits, de 0 18.446.744.073.709.551.615
            #endregion

            sbyte novoSbyte;

            novoSbyte = 100; // Tipo por valor
            novoSbyte = meuSByte;

            meuSByte = 1; // N altera o valor de novoSbyte

            Console.WriteLine(novoSbyte);

            // Para o console n fechar ao executar um programa .exe
            Console.ReadKey(); 
        }
    }
}
