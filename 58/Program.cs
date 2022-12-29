// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
GetinArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintinArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
GetinArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintinArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintinArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void GetinArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintinArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}