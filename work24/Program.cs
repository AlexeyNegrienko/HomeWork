﻿
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int max1=0;
int max2=0;
while (n != 0)
{
   n = Convert.ToInt32(Console.ReadLine());
   if (max1==0)
    max1=n;
    else if (max2==0)
    max2=n;
    if (n>max1)
    {
    max2=max1;
    max1=n;
    }
    else if (n>max2)
    {
    max2=n;
    }
}
Console.WriteLine(max2);