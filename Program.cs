//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите число, определяющее длинну массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] NewArray(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}
int[] array = new int[length];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }    
}
if (count == 0)
{
    Console.WriteLine("Чётные числа не найдены");
}
else
{
Console.WriteLine("Kоличество чётных чисел в массиве:" + count);
}