
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);

int minsumofline = 0;
int sumofline = SumOfEveryRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumOfEveryRow(array, i);
    if (sumofline > tempSumLine)
    {
        sumofline = tempSumLine;
        minsumofline = i + 1;
    }
}

Console.WriteLine($"{minsumofline} - строчка с наименьшей суммой, которая = {sumofline}");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfEveryRow(int[,] inArray, int i) // сумма каждой строки
{
    int sumofline = inArray[i, 0];
    for (int j = 1; j < inArray.GetLength(1); j++)
    {
        sumofline += inArray[i, j];
    }
    return sumofline;
}