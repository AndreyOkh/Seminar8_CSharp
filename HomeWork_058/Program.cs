// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int columnArray = ReadInt("Введите количество столбцов: ");
int rowArray = ReadInt("Введите количество строк: ");

int[,] firstMatrix = new int[rowArray, columnArray];
FillArrayRandom(firstMatrix);
Console.WriteLine("Первая матрица");
PrintArray(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = new int[rowArray, columnArray];
FillArrayRandom(secondMatrix);
Console.WriteLine("Вторая матрица");
PrintArray(secondMatrix);
Console.WriteLine();

int[,] multiplicationMatrix = OpMatrix(firstMatrix, secondMatrix, columnArray, rowArray);
Console.WriteLine("Матрица произведений маассивов");
PrintArray(multiplicationMatrix);

int[,] OpMatrix(int[,] firstMatrix, int[,] secondMatrix, int columnArray, int rowArray)
{
    int[,] result = new int[rowArray, columnArray];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            result[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }
    return result;
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