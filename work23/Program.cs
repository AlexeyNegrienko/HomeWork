// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблись!\nВведите день недели: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n<6)
{
Console.WriteLine("Будний день");
}
else
Console.WriteLine("Выходной");
