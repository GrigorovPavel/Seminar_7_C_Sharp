// Задача 46:
// Задайте двумерный массив, размером m * n
// заполненный случайными целыми числами
// m=3, n=4

//     0  1  2  3

// 0   1  2  3  4
// 1   3  2  5  8
// 2   9  8  6  7

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Создаем Метод для Массива с переменными size, max, min 
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // Счетчик для строк (3 строки) При таком расположении цикла
    // мы проходим условие по строкам. Если поменять местами Циклы for для i и j , то мы будем проходить по столбцам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Счетчик для столбцов (4 столбца)
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


int[,] matrix = CreateMatrixRndInt(3, 4, -100, 100);
PriintMatrix(matrix);

