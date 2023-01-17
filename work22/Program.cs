//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100)
Console.WriteLine("в числе нет третьей цифры");  
else
{
while(n>999)
   {
   n = n/10; 
   }
Console.WriteLine($"{n=n%10}");
}
