
Console.Clear();
Console.Write("Введите число кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
array[i] = Convert.ToInt32(Console.ReadLine());

int maxS = 0;
for (int i = 1; i < array.Length - 1; i++)
{
int sum = array[i - 1] + array[i] + array[i + 1];
if (sum > maxS)
maxS = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxS)
maxS = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxS)
maxS = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxS);