// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int columnArray = ReadInt("Введите количество столбцов: ");
int rowArray = ReadInt("Введите количество строк: ");

int[,] matrix = new int[rowArray, columnArray];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
int[,] matrixSort = SortArray(matrix);
PrintArray(matrixSort);

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int b = j + 1; b < array.GetLength(1); b++)
            {
                if (array[i, j] > array[i, b])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, b];
                    array[i, b] = temp;
                }
            }
        }

    }
    return matrix;
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
            array[i, j] = rand.Next(1, 10);
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