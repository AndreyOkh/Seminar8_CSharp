// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matrix = new int[2, 2, 2];
FillArrayUnique(matrix);
PrintArray(matrix);

void FillArrayUnique(int[,,] array)
{
    Random r = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(2); b++)
            {
                int unique = 0;
                
                do
                {
                    unique = 0;
                    int randomNumber = r.Next(10, 100);
                    foreach (int item in array)
                    {
                        if (item == randomNumber) unique++;
                    }
                    if (unique == 0)
                    {
                        array[i,j,b] = randomNumber;
                    }
                    
                }
                while (unique > 0);

            }
        }
        
    }
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(2); b++)
            {
                Console.Write($"{array[i, j, b]} ({i}, {j}, {b})\t");
            }
            Console.WriteLine();
        }
        
    }
}