﻿// // Задача 47. Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.
void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(-99,99)/10.0; 
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);

