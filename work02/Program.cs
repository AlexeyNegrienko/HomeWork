Console.Clear();
Console.Write("Введите 1-ое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int y = Convert.ToInt32(Console.ReadLine());
    int max=x;
    int min=y;
if (x>y) 
{
Console.WriteLine($"максимальное число: {max}");   
Console.WriteLine($"минимальное число: {min}");
} 
if (x<y)
{
    max=y;
    min=x;
Console.WriteLine($"максимальное число: {max}");   
Console.WriteLine($"минимальное число: {min}");
}
if (x==y)
    Console.WriteLine($"числа равны");
