//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк первой матрицы: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());
//Количество строк второй матрицы равно количеству столбцов первой матрицы чтобы не сломать математику
int str2 = col1;
Console.Write("Введите количество столбцов второй матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[str1, col1];
int[,] matrix2 = new int[str2, col2];
int[,] result = new int[str1, col2];
FillArrayRandomNumbers(matrix1);
FillArrayRandomNumbers(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < col1; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

PrintArray(result);


void FillArrayRandomNumbers(int[,] array)
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
