// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int columnArray = ReadInt("Введите количество столбцов: ");
int rowArray = ReadInt("Введите количество строк: ");

int[,] matrix = new int[columnArray, rowArray];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
matrix = SwapArray(matrix);
PrintArray(matrix);

int[,] SwapArray(int[,] array)
{
    int columnArray = array.GetLength(1);
    int rowArray = array.GetLength(0);
    int[,] matrix = new int[columnArray, rowArray];

    for (int i = 0; i < columnArray; i++)
    {
        for (int j = 0; j < rowArray; j++)
        {
            matrix[i, j] = array[j, i];
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