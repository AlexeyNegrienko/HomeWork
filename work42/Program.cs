// Сумма цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x=0;
while (n > 0)
{
x=x+n%10;
n=n/10;
}
Console.WriteLine(x);