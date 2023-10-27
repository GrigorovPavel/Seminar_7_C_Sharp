// Зфдача 51
// Задайте двумерный массив.
// Найдите сумму элементов находящихся на главной диагонали
// с индексами (0,0), (1,1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Создаем двумерный Массив со случайными числами
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

int SumElementsOfDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

int SumElementsOfDiagonalVers2(int[,] arr)
{
    int size = arr.GetLength(1); // ИЗНАЧАЛЬНО size Задаем длинну диагонали равную количествк столбцов
    if(arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0); // Данное условие проверяет, что 
    // если , количество строк меньше количества столбцов, то присваивает значение количества строк в -> size.
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}


int[,] matrix = CreateMatrixRndInt(4, 4, 1, 9);
PriintMatrix(matrix);
Console.WriteLine();
int result = SumElementsOfDiagonal(matrix);
Console.WriteLine($"Cумму элементов находящихся на главной диагонали -> {result}");

Console.WriteLine("------");

int res = SumElementsOfDiagonalVers2(matrix);
Console.WriteLine($"Cумму элементов находящихся на главной диагонали -> {res}");
