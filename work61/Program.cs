// Задача 41:Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > 0)
count++; 
}
Console.WriteLine($"Количество чисел больше 0 равно: {count}");
