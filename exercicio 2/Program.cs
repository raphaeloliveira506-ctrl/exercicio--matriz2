using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[501, 501];

        bool repetido = false;

        for (int i = 1; i <= N; i++)
        {
            string[] dados = Console.ReadLine().Split();

            int x = int.Parse(dados[0]);
            int y = int.Parse(dados[1]);

            if (matriz[x, y] == 1)
            {
                repetido = true;
            }

            matriz[x, y] = 1;
        }

        if (repetido == true)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
