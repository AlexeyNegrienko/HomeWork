Console.Clear();
Console.Write("Введите 1-ое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max=x;
if (y>max)
    max=y;
if (z>max)
    max=z;
  Console.WriteLine($"{max}");   
    
