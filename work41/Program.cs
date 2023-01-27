// Возводит a в степень b
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()),x=1;
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= b; i++)
{
x = x * a;
}
Console.WriteLine(x);