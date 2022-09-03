// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int columnArray = ReadInt("Введите количество столбцов: ");
int rowArray = ReadInt("Введите количество строк: ");

int[,] matrix = new int[columnArray, rowArray];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();



matrix = RemoveRowAndColumnMatrix(matrix);
PrintArray(matrix);

int[,] RemoveRowAndColumnMatrix(int[,] matrix)
{
    int indexColumn = 0;
    int indexRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[indexColumn, indexRow])
            {
                indexColumn = i;
                indexRow = j;
            }
        }
    }
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int iNewMatrix = 0;
    int iMatrix = 0;
    
    while (iMatrix < matrix.GetLength(0))
    {
        int jNewMatrix = 0;
        int jMatrix = 0;
        if(iMatrix != indexColumn)
        {
            while (jMatrix < matrix.GetLength(1))
            {
                if (jMatrix != indexRow)
                {
                    int value = matrix[iMatrix, jMatrix];
                    newMatrix[iNewMatrix, jNewMatrix] = value;
                    jNewMatrix++;
                }
                jMatrix++;
            }
            iNewMatrix++;
        }
        iMatrix++;
    }

    return newMatrix;
}

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void FillArrayRandom (int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}