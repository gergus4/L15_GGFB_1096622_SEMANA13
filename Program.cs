internal class Program
{
    static void Main()
    {
        Console.WriteLine("SUMA DE ELEMENTOS POSITIVOS, NEGATIVOS (TABLA 40*50)");
        int[,] mat = new int[40,50];
        int numpos = 0;
        int numneg = 0;

        Random random = new Random();
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                mat[i,j] = random.Next(-1000,1000);
            }
        }

        for (int i = 0; i <40; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (mat[i,j] >= 0)
                {
                    numpos = numpos + mat[i,j];
                }

                else
                {
                    numneg = numneg + mat[i,j];
                }
            }
        }

        Console.WriteLine("La suma de los numeros que son positivos es: " + numpos);
        Console.WriteLine("La suma de los numeros que son negativos es: " + numneg);
        Console.WriteLine("GRACIAS POR USAR EL PROGRAMA");

    }
}