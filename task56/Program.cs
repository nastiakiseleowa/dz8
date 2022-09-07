//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int str = 4;
int col = 4;
int[,] array = new int[str, col];
FillArray(array);
Console.WriteLine("Наш прямоугольный массив");
PrintArray(array);
int index = 0;
int minsum = 999999;
int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine(sum);
    if (sum < minsum)
    {
        minsum = sum;
        index = i;
    }
}
Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (index + 1) + ", с суммой элементов равной: " + (minsum));

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
