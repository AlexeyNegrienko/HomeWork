void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,10); 
}
void ReleaseArray(int[] array)
 {
    int summa = 0;
    foreach (int element in array)
    {
        if (element%2==0);

        else
        summa += element;
    }
   Console.WriteLine($"Сумма нечетных чисел: {summa}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);