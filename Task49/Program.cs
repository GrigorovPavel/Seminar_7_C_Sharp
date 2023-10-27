// Зфдача 49
// Задайте двумерный массив.
// Найдите элементы у которых оба индекса четные и
// Замените эти элементы на их квадраты

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PriintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("["); 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}"); // Длинна строки в которую мы помещаем наш вывод [i, j], 5 символов
        }
        Console.WriteLine();
        //Console.Write("]"); 
    }
}

void ReplaceElemintOnSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
}

void ReplaceElemintOnSquareVers2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 9);
PriintMatrix(matrix);
Console.WriteLine();
// ReplaceElemintOnSquare(matrix);
// PriintMatrix(matrix);

ReplaceElemintOnSquareVers2(matrix);
PriintMatrix(matrix);


