// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandom(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write($"{Matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] Matrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillMatrixRandom(Matrix);
PrintMatrix(Matrix);

Console.WriteLine();

FillMatrixRandom(secondMatrix);
PrintMatrix(secondMatrix);

Console.WriteLine();

if (Matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < Matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += Matrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintMatrix(resultMatrix);
