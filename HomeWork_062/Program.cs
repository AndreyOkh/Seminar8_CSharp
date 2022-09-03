// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int sizeArray = ReadInt("Введите размер матрицы: ");

int[,] matrix = new int[sizeArray, sizeArray];
FillArray(matrix);
PrintArray(matrix);


int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void FillArray (int[,] array, int positionColumn = 0, int positionRow = 0, int value = 1, string direction = "up")
{
    array[positionRow, positionColumn] = value;
    int transferCase = 0;
    switch (direction)
    {
        
        case("up"):
            if(positionRow - 1 >= 0 && array[positionRow - 1, positionColumn] == 0)
            {
                FillArray(array, positionColumn, positionRow - 1, ++value, "up");
            }
            else if (transferCase++ < 1) 
            {
                goto case "right";
            }
            break;

        case("down"):
            if(positionRow + 1 < array.GetLength(0) && array[positionRow + 1, positionColumn] == 0)
            {
                FillArray(array, positionColumn, positionRow + 1, ++value, "down");
            }
            else if (transferCase++ < 1) 
            {
                goto case "left";
            }
            break;

        case("left"):
            if(positionColumn - 1 >= 0 && array[positionRow, positionColumn - 1] == 0)
            {
                FillArray(array, positionColumn - 1, positionRow, ++value, "left");
            }
            else if (transferCase++ < 1) 
            {
                goto case "up";
            }
            break;

        case("right"):
            if(positionColumn + 1 < array.GetLength(0) && array[positionRow, positionColumn + 1] == 0)
            {
                FillArray(array, positionColumn + 1, positionRow, ++value, "right");
            }
            else if (transferCase++ < 1) 
            {
                goto case "down";
            }
            break;
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}