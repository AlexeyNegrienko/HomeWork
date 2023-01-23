 // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.Clear();
    Console.WriteLine("Введите пятизначное число: ");
    int n = Convert.ToInt32((Console.ReadLine()));
    int x = 0;
    int i;
    for (i = n; i > 0; i = (i / 10))
{
    x =x*10+(i % 10);
  
}  
Console.WriteLine(x);
if (n==x)
{
    Console.WriteLine($"Число является полиндромом");
}
else
{
    Console.WriteLine($"Число не является полиндромом ");
}