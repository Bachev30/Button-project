using System;

Console.WriteLine("1: Umnoji s chislo");
Console.WriteLine("2: Suberi dve matrici");
Console.WriteLine("Napishi Izbora si");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("First matrix");
        double[,] matrix1 = new double[3, 3];
        double multiply = double.Parse(Console.ReadLine());

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
                matrix1[i, j] = matrix1[i, j] * multiply;
            }
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        break;

    case 2:
        Console.WriteLine("First matrix");
        double[,] caseTwoMatrix = new double[3, 3];

        for (int i = 0; i < caseTwoMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < caseTwoMatrix.GetLength(1); j++)
            {
                caseTwoMatrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int g = 0; g < caseTwoMatrix.GetLength(0); g++)
        {
            for (int r = 0; r < caseTwoMatrix.GetLength(1); r++)
            {
                Console.Write(caseTwoMatrix[g, r] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Second matrix");
        double[,] caseTwoSecondMatrix = new double[3, 3];

        for (int z = 0; z < caseTwoSecondMatrix.GetLength(0); z++)
        {
            for (int c = 0; c < caseTwoSecondMatrix.GetLength(1); c++)
            {
                caseTwoSecondMatrix[z, c] = int.Parse(Console.ReadLine());
            }
        }

        for (int k = 0; k < caseTwoSecondMatrix.GetLength(0); k++)
        {
            for (int l = 0; l < caseTwoSecondMatrix.GetLength(1); l++)
            {
                Console.Write(caseTwoSecondMatrix[k, l] + "\t");
            }
            Console.WriteLine();
        }

        double[,] finalMatrix = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                finalMatrix[i, j] = caseTwoMatrix[i, j] + caseTwoSecondMatrix[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Final result");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(finalMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        break;
}