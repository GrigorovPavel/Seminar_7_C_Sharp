// Задача 48
// Задайте двумерный Массив m х n
// Каждый элемент в массиве находится по формуле Amn = m + n
// Выведите полученный Массив на экран
// m=3, n=4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumIndex(int rows, int columns) // Метод для двумерного массива с переменными строка и столбец
{
    int[,] matrix = new int[rows, columns]; // Создаем новый двумерный массив

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = i + j; // Присваиваем значению элемента массива, сумму индексов
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


int[,] matrix = CreateMatrixSumIndex(10, 10);
PriintMatrix(matrix);

