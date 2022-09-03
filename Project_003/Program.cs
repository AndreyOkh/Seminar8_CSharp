// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int columnArray = ReadInt("Введите количество столбцов: ");
int rowArray = ReadInt("Введите количество строк: ");

int[,] matrix = new int[columnArray, rowArray];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();


for (int i = 0; i < 10; i++)
{
    int count = 0;
    foreach (int item in matrix)
    {
        if (item == i) count++;
    }
    if (count != 0) Console.WriteLine($"{i} встречается {count}  раз");
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